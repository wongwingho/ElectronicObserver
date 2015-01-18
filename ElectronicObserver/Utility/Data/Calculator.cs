﻿using ElectronicObserver.Data;
using ElectronicObserver.Resource.Record;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicObserver.Utility.Data {

	/// <summary>
	/// 汎用計算クラス
	/// </summary>
	public static class Calculator {

		/// <summary>
		/// レベルに依存するパラメータ値を求めます。
		/// </summary>
		/// <param name="min">初期値。</param>
		/// <param name="max">最大値。</param>
		/// <param name="lv">レベル。</param>
		/// <returns></returns>
		public static int GetParameterFromLevel( int min, int max, int lv ) {
			return min + ( max - min ) * lv / 99;
		}




		/// <summary>
		/// 制空戦力を求めます。
		/// </summary>
		/// <param name="slot">装備スロット。</param>
		/// <param name="aircraft">艦載機搭載量の配列。</param>
		public static int GetAirSuperiority( int[] slot, int[] aircraft ) {

			int air = 0;
			int length = Math.Min( slot.Length, aircraft.Length );

			for ( int s = 0; s < length; s++ ) {

				EquipmentDataMaster eq = KCDatabase.Instance.MasterEquipments[slot[s]];

				if ( eq == null ) continue;

				switch ( eq.EquipmentType[2] ) {
					case 6:
					case 7:
					case 8:
					case 11:
						air += (int)( eq.AA * Math.Sqrt( aircraft[s] ) );
						break;
				}
			}

			return air;
		}

		/// <summary>
		/// 制空戦力を求めます。
		/// </summary>
		/// <param name="fleet">艦船IDの配列。</param>
		public static int GetAirSuperiority( int[] fleet ) {

			int air = 0;

			for ( int i = 0; i < fleet.Length; i++ ) {
				ShipDataMaster ship = KCDatabase.Instance.MasterShips[fleet[i]];
				if ( ship == null ) continue;

				air += GetAirSuperiority( ship );
			}

			return air;
		}

		/// <summary>
		/// 制空戦力を求めます。
		/// </summary>
		/// <param name="fleet">艦船IDの配列。</param>
		/// <param name="slot">各艦船の装備スロット。</param>
		public static int GetAirSuperiority( int[] fleet, int[][] slot ) {

			int air = 0;
			int length = Math.Min( fleet.Length, slot.GetLength( 0 ) );

			for ( int i = 0; i < length; i++ ) {
				ShipDataMaster ship = KCDatabase.Instance.MasterShips[fleet[i]];
				if ( ship == null ) continue;

				air += GetAirSuperiority( slot[i], ship.Aircraft.ToArray() );

			}

			return air;
		}

		/// <summary>
		/// 制空戦力を求めます。
		/// </summary>
		/// <param name="ship">対象の艦船。</param>
		public static int GetAirSuperiority( ShipData ship ) {

			return GetAirSuperiority( ship.SlotMaster.ToArray(), ship.Aircraft.ToArray() );
	
		}

		/// <summary>
		/// 制空戦力を求めます。
		/// </summary>
		/// <param name="ship">対象の艦船。</param>
		public static int GetAirSuperiority( ShipDataMaster ship ) {

			if ( ship.DefaultSlot == null ) return 0;
			return GetAirSuperiority( ship.DefaultSlot.ToArray(), ship.Aircraft.ToArray() );

		}

		/// <summary>
		/// 制空戦力を求めます。
		/// </summary>
		/// <param name="fleet">対象の艦隊。</param>
		public static int GetAirSuperiority( FleetData fleet ) {

			int air = 0;

			foreach ( var ship in fleet.MembersInstance ) {
				if ( ship == null ) continue;

				air += GetAirSuperiority( ship );
			}

			return air;
		}



		/// <summary>
		/// 昼戦における攻撃種別を取得します。
		/// </summary>
		/// <param name="slot">攻撃艦のスロット(マスターID)。</param>
		/// <param name="attackerShipID">攻撃艦の艦船ID。</param>
		/// <param name="defenerShipID">防御艦の艦船ID。なければ-1</param>
		public static int GetDayAttackKind( int[] slot, int attackerShipID, int defenerShipID ) {

			int reconcnt = 0;
			int mainguncnt = 0;
			int subguncnt = 0;
			int apshellcnt = 0;
			int radarcnt = 0;

			if ( slot == null ) return -1;

			for ( int i = 0; i < slot.Length; i++ ) {

				EquipmentDataMaster eq = KCDatabase.Instance.MasterEquipments[slot[i]];
				if ( eq == null ) continue;

				int eqtype = eq.EquipmentType[2];

				switch ( eqtype ) {
					case 1:
					case 2:
					case 3:
						mainguncnt++;
						break;
					case 4:
						subguncnt++;
						break;
					case 10:
					case 11:
						reconcnt++;
						break;
					case 12:
					case 13:
						radarcnt++;
						break;
					case 19:
						apshellcnt++;
						break;
				}
			}

			if ( reconcnt > 0 ) {
				if ( mainguncnt == 2 && apshellcnt == 1 )
					return 6;		//カットイン(主砲/主砲)
				else if ( mainguncnt == 1 && subguncnt == 1 && apshellcnt == 1 )
					return 5;		//カットイン(主砲/徹甲弾)
				else if ( mainguncnt == 1 && subguncnt == 1 && radarcnt == 1 )
					return 4;		//カットイン(主砲/電探)
				else if ( mainguncnt >= 1 && subguncnt >= 1 )
					return 3;		//カットイン(主砲/副砲)
				else if ( mainguncnt >= 2 )
					return 2;		//連撃
			}


			ShipDataMaster atkship = KCDatabase.Instance.MasterShips[attackerShipID];
			ShipDataMaster defship = KCDatabase.Instance.MasterShips[defenerShipID];

			if ( atkship != null ) {

				if ( atkship.ShipType == 7 || atkship.ShipType == 11 || atkship.ShipType == 18 )		//軽空母/正規空母/装甲空母
					return 7;		//空撃
				else if ( defship != null && ( defship.ShipType == 13 || defship.ShipType == 14 ) )			//潜水艦/潜水空母
					if ( atkship.ShipType == 6 || atkship.ShipType == 10 ||
						 atkship.ShipType == 16 || atkship.ShipType == 17 )			//航空巡洋艦/航空戦艦/水上機母艦/揚陸艦
						return 7;		//空撃
					else
						return 8;		//爆雷攻撃

				//本来の雷撃は発生しえない

				else if ( atkship.ShipType == 13 || atkship.ShipType == 14 )		//潜水艦/潜水空母
					return 9;			//雷撃(特例措置, 本来のコード中には存在しない)
			}

			return 0;
		}


		/// <summary>
		/// 夜戦における攻撃種別を取得します。
		/// </summary>
		/// <param name="slot">攻撃艦のスロット(マスターID)。</param>
		/// <param name="attackerShipID">攻撃艦の艦船ID。</param>
		/// <param name="defenerShipID">防御艦の艦船ID。なければ-1</param>
		public static int GetNightAttackKind( int[] slot, int attackerShipID, int defenerShipID ) {

			int mainguncnt = 0;
			int subguncnt = 0;
			int torpcnt = 0;

			if ( slot == null ) return -1;

			for ( int i = 0; i < slot.Length; i++ ) {
				EquipmentDataMaster eq = KCDatabase.Instance.MasterEquipments[slot[i]];
				if ( eq == null ) continue;

				int eqtype = eq.EquipmentType[2];

				switch ( eqtype ) {
					case 1:
					case 2:
					case 3:
						mainguncnt++; break;	//主砲

					case 4:
						subguncnt++; break;		//副砲

					case 5:
					case 32:
						torpcnt++; break;		//魚雷
				}

			}


			if ( torpcnt >= 2 )
				return 3;			//カットイン(魚雷/魚雷)
			else if ( mainguncnt >= 3 )
				return 5;			//カットイン(主砲x3)
			else if ( mainguncnt == 2 && subguncnt > 0 )
				return 4;			//カットイン(主砲x2/副砲)
			else if ( ( mainguncnt == 2 && subguncnt == 0 && torpcnt == 1 ) || ( mainguncnt == 1 && torpcnt == 1 ) )
				return 2;			//カットイン(主砲/魚雷)
			else if ( ( mainguncnt == 2 && subguncnt == 0 & torpcnt == 0 ) ||
				( mainguncnt == 1 && subguncnt > 0 ) ||
				( subguncnt >= 2 && torpcnt <= 1 ) ) {
				return 1;			//連撃
			}


			ShipDataMaster atkship = KCDatabase.Instance.MasterShips[attackerShipID];
			ShipDataMaster defship = KCDatabase.Instance.MasterShips[defenerShipID];

			if ( atkship != null ) {

				if ( atkship.ShipType == 7 || atkship.ShipType == 11 || atkship.ShipType == 18 )		//軽空母/正規空母/装甲空母
					return 7;		//空撃
				else if ( defship != null && ( defship.ShipType == 13 || defship.ShipType == 14 ) )			//潜水艦/潜水空母
					if ( atkship.ShipType == 6 || atkship.ShipType == 10 ||
						 atkship.ShipType == 16 || atkship.ShipType == 17 )			//航空巡洋艦/航空戦艦/水上機母艦/揚陸艦
						return 7;		//空撃
					else
						return 8;		//爆雷攻撃
				else if ( atkship.ShipType == 13 || atkship.ShipType == 14 )	//潜水艦/潜水空母
					return 9;			//雷撃
				else if ( slot.Length > 0 ) {
					EquipmentDataMaster eq = KCDatabase.Instance.MasterEquipments[slot[0]];
					if ( eq != null && eq.EquipmentType[2] == 5 ) {		//最初のスロット==魚雷		(本来の判定とは微妙に異なるが無問題)
							return 9;		//雷撃
					}
				}

			}

			return 0;		//砲撃

		}

	}


}
