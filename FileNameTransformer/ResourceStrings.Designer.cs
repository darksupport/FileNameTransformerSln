﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FileNameTransformer {
    using System;
    
    
    /// <summary>
    ///   Класс ресурса со строгой типизацией для поиска локализованных строк и т.д.
    /// </summary>
    // Этот класс создан автоматически классом StronglyTypedResourceBuilder
    // с помощью такого средства, как ResGen или Visual Studio.
    // Чтобы добавить или удалить член, измените файл .ResX и снова запустите ResGen
    // с параметром /str или перестройте свой проект VS.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class ResourceStrings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ResourceStrings() {
        }
        
        /// <summary>
        ///   Возвращает кэшированный экземпляр ResourceManager, использованный этим классом.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("FileNameTransformer.ResourceStrings", typeof(ResourceStrings).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Перезаписывает свойство CurrentUICulture текущего потока для всех
        ///   обращений к ресурсу с помощью этого класса ресурса со строгой типизацией.
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
        ///   Ищет локализованную строку, похожую на Directory {0} not found..
        /// </summary>
        internal static string DirectoryNotFound {
            get {
                return ResourceManager.GetString("DirectoryNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Empty path to directory..
        /// </summary>
        internal static string EmptyPathDirectory {
            get {
                return ResourceManager.GetString("EmptyPathDirectory", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Empty transform type..
        /// </summary>
        internal static string EmptyTransformType {
            get {
                return ResourceManager.GetString("EmptyTransformType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Exception in perform action {0}. For input string: {1}.
        /// </summary>
        internal static string ExceptionInPerfAct {
            get {
                return ResourceManager.GetString("ExceptionInPerfAct", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Houston we have a problem!!!.
        /// </summary>
        internal static string FatalError {
            get {
                return ResourceManager.GetString("FatalError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на *.*.
        /// </summary>
        internal static string FileSearchMask {
            get {
                return ResourceManager.GetString("FileSearchMask", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Incorrect transform type: {0}.
        /// </summary>
        internal static string IncorectTransformType {
            get {
                return ResourceManager.GetString("IncorectTransformType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Incorrect count of args..
        /// </summary>
        internal static string IncorrectCountOfArgs {
            get {
                return ResourceManager.GetString("IncorrectCountOfArgs", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Invoke transform action: {0} \n Input string: {1}.
        /// </summary>
        internal static string InvokeTransAct {
            get {
                return ResourceManager.GetString("InvokeTransAct", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Problem with collect file names.
        /// </summary>
        internal static string ProblemWithFileNameCollect {
            get {
                return ResourceManager.GetString("ProblemWithFileNameCollect", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на result.txt.
        /// </summary>
        internal static string ResultFile {
            get {
                return ResourceManager.GetString("ResultFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Result transform action: {0}.
        /// </summary>
        internal static string ResultTransAct {
            get {
                return ResourceManager.GetString("ResultTransAct", resourceCulture);
            }
        }
    }
}