﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Browser.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Browser.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 下(&amp;B).
        /// </summary>
        internal static string Alignment_Bottom {
            get {
                return ResourceManager.GetString("Alignment_Bottom", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 非表示(&amp;I).
        /// </summary>
        internal static string Alignment_Invisible {
            get {
                return ResourceManager.GetString("Alignment_Invisible", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 左(&amp;L).
        /// </summary>
        internal static string Alignment_Left {
            get {
                return ResourceManager.GetString("Alignment_Left", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 右(&amp;R).
        /// </summary>
        internal static string Alignment_Right {
            get {
                return ResourceManager.GetString("Alignment_Right", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 上(&amp;T).
        /// </summary>
        internal static string Alignment_Top {
            get {
                return ResourceManager.GetString("Alignment_Top", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 削除完了.
        /// </summary>
        internal static string ClearComplete {
            get {
                return ResourceManager.GetString("ClearComplete", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to キャッシュの削除が完了しました。.
        /// </summary>
        internal static string ClearCompleteDialog {
            get {
                return ResourceManager.GetString("ClearCompleteDialog", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 確認.
        /// </summary>
        internal static string Confirm {
            get {
                return ResourceManager.GetString("Confirm", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 対象の swf が見つかりませんでした。.
        /// </summary>
        internal static string CouldntFindSWF {
            get {
                return ResourceManager.GetString("CouldntFindSWF", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to embed 要素の取得に失敗しました。.
        /// </summary>
        internal static string CouldntLoadEmbed {
            get {
                return ResourceManager.GetString("CouldntLoadEmbed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 現在: .
        /// </summary>
        internal static string CurrentZoom {
            get {
                return ResourceManager.GetString("CurrentZoom", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 
        ///try {
        ///	if ( DMM.netgame.reloadDialog ) DMM.netgame.reloadDialog = function (){};
        ///}
        ///catch(e) {
        ///	alert(&quot;DMMによるページ更新ダイアログの非表示に失敗しました: &quot;+e);
        ///}.
        /// </summary>
        internal static string DMMScript {
            get {
                return ResourceManager.GetString("DMMScript", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to スタイルシートの適用に失敗しました。.
        /// </summary>
        internal static string FailedToApplyStylesheet {
            get {
                return ResourceManager.GetString("FailedToApplyStylesheet", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ズームの適用に失敗しました。.
        /// </summary>
        internal static string FailedToApplyZoom {
            get {
                return ResourceManager.GetString("FailedToApplyZoom", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 
        ///try {{
        ///var node = document.getElementById(&apos;{0}&apos;);
        ///if (node) document.getElementsByTagName(&apos;head&apos;)[0].removeChild(node);
        ///node = document.createElement(&apos;div&apos;);
        ///node.innerHTML = &apos;F&lt;style id=\&apos;{0}\&apos;&gt;body {{ visibility: hidden; }} \
        ///#flashWrap {{ position: fixed; left: 0; top: 0; width: 100% !important; height: 100% !important; }} \
        ///#externalswf {{ visibility: visible; width: 100% !important; height: 100% !important; }}&lt;/style&gt;&apos;;
        ///document.getElementsByTagName(&apos;head&apos;)[0].appendChild(node.lastChild);
        ///}}        /// [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string FrameScript {
            get {
                return ResourceManager.GetString("FrameScript", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 情報.
        /// </summary>
        internal static string Information {
            get {
                return ResourceManager.GetString("Information", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ログインページへ移動します。
        ///よろしいですか？.
        /// </summary>
        internal static string LoginDialog {
            get {
                return ResourceManager.GetString("LoginDialog", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 艦これが読み込まれていないため、スクリーンショットを撮ることはできません。.
        /// </summary>
        internal static string NoScreenshotUnloaded {
            get {
                return ResourceManager.GetString("NoScreenshotUnloaded", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to その他.
        /// </summary>
        internal static string Other {
            get {
                return ResourceManager.GetString("Other", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 配置(&amp;A).
        /// </summary>
        internal static string Other_Alignment {
            get {
                return ResourceManager.GetString("Other_Alignment", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to スタイルシートを適用する.
        /// </summary>
        internal static string Other_ApplyStyleSheet {
            get {
                return ResourceManager.GetString("Other_ApplyStyleSheet", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 移動(&amp;N)....
        /// </summary>
        internal static string Other_Navigate {
            get {
                return ResourceManager.GetString("Other_Navigate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ログインページへ移動(&amp;L).
        /// </summary>
        internal static string Other_NavigateToLogInPage {
            get {
                return ResourceManager.GetString("Other_NavigateToLogInPage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 地域制限クッキーを設定.
        /// </summary>
        internal static string Other_RegionCookie {
            get {
                return ResourceManager.GetString("Other_RegionCookie", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ズーム(&amp;Z).
        /// </summary>
        internal static string Other_Zoom {
            get {
                return ResourceManager.GetString("Other_Zoom", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 現在% .
        /// </summary>
        internal static string Other_Zoom_Current {
            get {
                return ResourceManager.GetString("Other_Zoom_Current", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ぴったり.
        /// </summary>
        internal static string Other_Zoom_Fit {
            get {
                return ResourceManager.GetString("Other_Zoom_Fit", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 
        ///try {{
        ///var node = document.getElementById(&apos;{0}&apos;);
        ///if (node) document.getElementsByTagName(&apos;head&apos;)[0].removeChild(node);
        ///node = document.createElement(&apos;div&apos;);
        ///node.innerHTML = &apos;P&lt;style id=\&apos;{0}\&apos;&gt;body {{ visibility: hidden; overflow: hidden; }} \
        ///div #block_background {{ visibility: visible; }} \
        ///div #alert {{ visibility: visible; overflow: scroll; overflow-x: hidden; top: 3% !important; left: 3% !important; width: 94% !important; height: 94%; padding: 2%; box-sizing: border-box;}} \
        ///div.dmm-ntgnavi [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string PageScript {
            get {
                return ResourceManager.GetString("PageScript", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 再読み込みします。
        ///よろしいですか？.
        /// </summary>
        internal static string ReloadDialog {
            get {
                return ResourceManager.GetString("ReloadDialog", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to スクリーンショットの保存時にエラーが発生しました。.
        /// </summary>
        internal static string ScreenshotError {
            get {
                return ResourceManager.GetString("ScreenshotError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to スクリーンショットを {0} に保存しました。.
        /// </summary>
        internal static string ScreenshotSaved {
            get {
                return ResourceManager.GetString("ScreenshotSaved", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ツールメニューを表示.
        /// </summary>
        internal static string ShowToolMenu {
            get {
                return ResourceManager.GetString("ShowToolMenu", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ミュート.
        /// </summary>
        internal static string Strip_Mute {
            get {
                return ResourceManager.GetString("Strip_Mute", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ログインページへ移動.
        /// </summary>
        internal static string Strip_NavigateToLogInPage {
            get {
                return ResourceManager.GetString("Strip_NavigateToLogInPage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 更新.
        /// </summary>
        internal static string Strip_Refresh {
            get {
                return ResourceManager.GetString("Strip_Refresh", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to スクリーンショット.
        /// </summary>
        internal static string Strip_ScreenShot {
            get {
                return ResourceManager.GetString("Strip_ScreenShot", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ズーム.
        /// </summary>
        internal static string Strip_Zoom {
            get {
                return ResourceManager.GetString("Strip_Zoom", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to これは七四式電子観測儀のサブプログラムであり、単体では起動できません。\r\n本体から起動してください。.
        /// </summary>
        internal static string SubProgramWarning {
            get {
                return ResourceManager.GetString("SubProgramWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 七四式電子観測儀 ブラウザ.
        /// </summary>
        internal static string Title {
            get {
                return ResourceManager.GetString("Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 音量(&amp;V).
        /// </summary>
        internal static string Volume {
            get {
                return ResourceManager.GetString("Volume", resourceCulture);
            }
        }
    }
}
