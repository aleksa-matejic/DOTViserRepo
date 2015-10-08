﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------



namespace designIdea002
{
    public partial class App : global::Windows.UI.Xaml.Markup.IXamlMetadataProvider
    {
        private global::designIdea002.designIdea002_XamlTypeInfo.XamlTypeInfoProvider _provider;

        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlType(global::System.Type type)
        {
            if(_provider == null)
            {
                _provider = new global::designIdea002.designIdea002_XamlTypeInfo.XamlTypeInfoProvider();
            }
            return _provider.GetXamlTypeByType(type);
        }

        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlType(string fullName)
        {
            if(_provider == null)
            {
                _provider = new global::designIdea002.designIdea002_XamlTypeInfo.XamlTypeInfoProvider();
            }
            return _provider.GetXamlTypeByName(fullName);
        }

        public global::Windows.UI.Xaml.Markup.XmlnsDefinition[] GetXmlnsDefinitions()
        {
            return new global::Windows.UI.Xaml.Markup.XmlnsDefinition[0];
        }
    }
}

namespace designIdea002.designIdea002_XamlTypeInfo
{
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")]    
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal partial class XamlTypeInfoProvider
    {
        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlTypeByType(global::System.Type type)
        {
            global::Windows.UI.Xaml.Markup.IXamlType xamlType;
            if (_xamlTypeCacheByType.TryGetValue(type, out xamlType))
            {
                return xamlType;
            }
            int typeIndex = LookupTypeIndexByType(type);
            if(typeIndex != -1)
            {
                xamlType = CreateXamlType(typeIndex);
            }
            if (xamlType != null)
            {
                _xamlTypeCacheByName.Add(xamlType.FullName, xamlType);
                _xamlTypeCacheByType.Add(xamlType.UnderlyingType, xamlType);
            }
            return xamlType;
        }

        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlTypeByName(string typeName)
        {
            if (string.IsNullOrEmpty(typeName))
            {
                return null;
            }
            global::Windows.UI.Xaml.Markup.IXamlType xamlType;
            if (_xamlTypeCacheByName.TryGetValue(typeName, out xamlType))
            {
                return xamlType;
            }
            int typeIndex = LookupTypeIndexByName(typeName);
            if(typeIndex != -1)
            {
                xamlType = CreateXamlType(typeIndex);
            }
            if (xamlType != null)
            {
                _xamlTypeCacheByName.Add(xamlType.FullName, xamlType);
                _xamlTypeCacheByType.Add(xamlType.UnderlyingType, xamlType);
            }
            return xamlType;
        }

        public global::Windows.UI.Xaml.Markup.IXamlMember GetMemberByLongName(string longMemberName)
        {
            if (string.IsNullOrEmpty(longMemberName))
            {
                return null;
            }
            global::Windows.UI.Xaml.Markup.IXamlMember xamlMember;
            if (_xamlMembers.TryGetValue(longMemberName, out xamlMember))
            {
                return xamlMember;
            }
            xamlMember = CreateXamlMember(longMemberName);
            if (xamlMember != null)
            {
                _xamlMembers.Add(longMemberName, xamlMember);
            }
            return xamlMember;
        }

        global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlType>
                _xamlTypeCacheByName = new global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlType>();

        global::System.Collections.Generic.Dictionary<global::System.Type, global::Windows.UI.Xaml.Markup.IXamlType>
                _xamlTypeCacheByType = new global::System.Collections.Generic.Dictionary<global::System.Type, global::Windows.UI.Xaml.Markup.IXamlType>();

        global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlMember>
                _xamlMembers = new global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlMember>();

        string[] _typeNameTable = null;
        global::System.Type[] _typeTable = null;

        private void InitTypeTables()
        {
            _typeNameTable = new string[17];
            _typeNameTable[0] = "designIdea002.Common.BooleanToVisibilityConverter";
            _typeNameTable[1] = "Object";
            _typeNameTable[2] = "designIdea002.MainPage";
            _typeNameTable[3] = "Windows.UI.Xaml.Controls.Page";
            _typeNameTable[4] = "Windows.UI.Xaml.Controls.UserControl";
            _typeNameTable[5] = "designIdea002.Common.ObservableDictionary";
            _typeNameTable[6] = "String";
            _typeNameTable[7] = "designIdea002.PdfPage";
            _typeNameTable[8] = "designIdea002.Common.NavigationHelper";
            _typeNameTable[9] = "Windows.UI.Xaml.DependencyObject";
            _typeNameTable[10] = "designIdea002.Profesor";
            _typeNameTable[11] = "designIdea002.Profesori";
            _typeNameTable[12] = "designIdea002.Smerovi";
            _typeNameTable[13] = "designIdea002.Studenti";
            _typeNameTable[14] = "Int32";
            _typeNameTable[15] = "designIdea002.Timovi";
            _typeNameTable[16] = "designIdea002.Vesti";

            _typeTable = new global::System.Type[17];
            _typeTable[0] = typeof(global::designIdea002.Common.BooleanToVisibilityConverter);
            _typeTable[1] = typeof(global::System.Object);
            _typeTable[2] = typeof(global::designIdea002.MainPage);
            _typeTable[3] = typeof(global::Windows.UI.Xaml.Controls.Page);
            _typeTable[4] = typeof(global::Windows.UI.Xaml.Controls.UserControl);
            _typeTable[5] = typeof(global::designIdea002.Common.ObservableDictionary);
            _typeTable[6] = typeof(global::System.String);
            _typeTable[7] = typeof(global::designIdea002.PdfPage);
            _typeTable[8] = typeof(global::designIdea002.Common.NavigationHelper);
            _typeTable[9] = typeof(global::Windows.UI.Xaml.DependencyObject);
            _typeTable[10] = typeof(global::designIdea002.Profesor);
            _typeTable[11] = typeof(global::designIdea002.Profesori);
            _typeTable[12] = typeof(global::designIdea002.Smerovi);
            _typeTable[13] = typeof(global::designIdea002.Studenti);
            _typeTable[14] = typeof(global::System.Int32);
            _typeTable[15] = typeof(global::designIdea002.Timovi);
            _typeTable[16] = typeof(global::designIdea002.Vesti);
        }

        private int LookupTypeIndexByName(string typeName)
        {
            if (_typeNameTable == null)
            {
                InitTypeTables();
            }
            for (int i=0; i<_typeNameTable.Length; i++)
            {
                if(0 == string.CompareOrdinal(_typeNameTable[i], typeName))
                {
                    return i;
                }
            }
            return -1;
        }

        private int LookupTypeIndexByType(global::System.Type type)
        {
            if (_typeTable == null)
            {
                InitTypeTables();
            }
            for(int i=0; i<_typeTable.Length; i++)
            {
                if(type == _typeTable[i])
                {
                    return i;
                }
            }
            return -1;
        }

        private object Activate_0_BooleanToVisibilityConverter() { return new global::designIdea002.Common.BooleanToVisibilityConverter(); }
        private object Activate_2_MainPage() { return new global::designIdea002.MainPage(); }
        private object Activate_5_ObservableDictionary() { return new global::designIdea002.Common.ObservableDictionary(); }
        private object Activate_7_PdfPage() { return new global::designIdea002.PdfPage(); }
        private object Activate_10_Profesor() { return new global::designIdea002.Profesor(); }
        private object Activate_11_Profesori() { return new global::designIdea002.Profesori(); }
        private object Activate_12_Smerovi() { return new global::designIdea002.Smerovi(); }
        private object Activate_13_Studenti() { return new global::designIdea002.Studenti(); }
        private object Activate_15_Timovi() { return new global::designIdea002.Timovi(); }
        private object Activate_16_Vesti() { return new global::designIdea002.Vesti(); }
        private void MapAdd_5_ObservableDictionary(object instance, object key, object item)
        {
            var collection = (global::System.Collections.Generic.IDictionary<global::System.String, global::System.Object>)instance;
            var newKey = (global::System.String)key;
            var newItem = (global::System.Object)item;
            collection.Add(newKey, newItem);
        }

        private global::Windows.UI.Xaml.Markup.IXamlType CreateXamlType(int typeIndex)
        {
            global::designIdea002.designIdea002_XamlTypeInfo.XamlSystemBaseType xamlType = null;
            global::designIdea002.designIdea002_XamlTypeInfo.XamlUserType userType;
            string typeName = _typeNameTable[typeIndex];
            global::System.Type type = _typeTable[typeIndex];

            switch (typeIndex)
            {

            case 0:   //  designIdea002.Common.BooleanToVisibilityConverter
                userType = new global::designIdea002.designIdea002_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Object"));
                userType.Activator = Activate_0_BooleanToVisibilityConverter;
                xamlType = userType;
                break;

            case 1:   //  Object
                xamlType = new global::designIdea002.designIdea002_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 2:   //  designIdea002.MainPage
                userType = new global::designIdea002.designIdea002_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_2_MainPage;
                userType.AddMemberName("DefaultViewModel");
                xamlType = userType;
                break;

            case 3:   //  Windows.UI.Xaml.Controls.Page
                xamlType = new global::designIdea002.designIdea002_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 4:   //  Windows.UI.Xaml.Controls.UserControl
                xamlType = new global::designIdea002.designIdea002_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 5:   //  designIdea002.Common.ObservableDictionary
                userType = new global::designIdea002.designIdea002_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Object"));
                userType.DictionaryAdd = MapAdd_5_ObservableDictionary;
                userType.SetIsReturnTypeStub();
                xamlType = userType;
                break;

            case 6:   //  String
                xamlType = new global::designIdea002.designIdea002_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 7:   //  designIdea002.PdfPage
                userType = new global::designIdea002.designIdea002_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_7_PdfPage;
                userType.AddMemberName("NavigationHelper");
                userType.AddMemberName("DefaultViewModel");
                xamlType = userType;
                break;

            case 8:   //  designIdea002.Common.NavigationHelper
                userType = new global::designIdea002.designIdea002_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.DependencyObject"));
                userType.SetIsReturnTypeStub();
                xamlType = userType;
                break;

            case 9:   //  Windows.UI.Xaml.DependencyObject
                xamlType = new global::designIdea002.designIdea002_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 10:   //  designIdea002.Profesor
                userType = new global::designIdea002.designIdea002_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_10_Profesor;
                xamlType = userType;
                break;

            case 11:   //  designIdea002.Profesori
                userType = new global::designIdea002.designIdea002_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_11_Profesori;
                userType.AddMemberName("DefaultViewModel");
                userType.AddMemberName("NavigationHelper");
                xamlType = userType;
                break;

            case 12:   //  designIdea002.Smerovi
                userType = new global::designIdea002.designIdea002_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_12_Smerovi;
                xamlType = userType;
                break;

            case 13:   //  designIdea002.Studenti
                userType = new global::designIdea002.designIdea002_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_13_Studenti;
                userType.AddMemberName("idPageSent");
                xamlType = userType;
                break;

            case 14:   //  Int32
                xamlType = new global::designIdea002.designIdea002_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 15:   //  designIdea002.Timovi
                userType = new global::designIdea002.designIdea002_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_15_Timovi;
                xamlType = userType;
                break;

            case 16:   //  designIdea002.Vesti
                userType = new global::designIdea002.designIdea002_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_16_Vesti;
                xamlType = userType;
                break;
            }
            return xamlType;
        }


        private object get_0_MainPage_DefaultViewModel(object instance)
        {
            var that = (global::designIdea002.MainPage)instance;
            return that.DefaultViewModel;
        }
        private object get_1_PdfPage_NavigationHelper(object instance)
        {
            var that = (global::designIdea002.PdfPage)instance;
            return that.NavigationHelper;
        }
        private object get_2_PdfPage_DefaultViewModel(object instance)
        {
            var that = (global::designIdea002.PdfPage)instance;
            return that.DefaultViewModel;
        }
        private object get_3_Profesori_DefaultViewModel(object instance)
        {
            var that = (global::designIdea002.Profesori)instance;
            return that.DefaultViewModel;
        }
        private object get_4_Profesori_NavigationHelper(object instance)
        {
            var that = (global::designIdea002.Profesori)instance;
            return that.NavigationHelper;
        }
        private object get_5_Studenti_idPageSent(object instance)
        {
            var that = (global::designIdea002.Studenti)instance;
            return that.idPageSent;
        }
        private void set_5_Studenti_idPageSent(object instance, object Value)
        {
            var that = (global::designIdea002.Studenti)instance;
            that.idPageSent = (global::System.Int32)Value;
        }

        private global::Windows.UI.Xaml.Markup.IXamlMember CreateXamlMember(string longMemberName)
        {
            global::designIdea002.designIdea002_XamlTypeInfo.XamlMember xamlMember = null;
            global::designIdea002.designIdea002_XamlTypeInfo.XamlUserType userType;

            switch (longMemberName)
            {
            case "designIdea002.MainPage.DefaultViewModel":
                userType = (global::designIdea002.designIdea002_XamlTypeInfo.XamlUserType)GetXamlTypeByName("designIdea002.MainPage");
                xamlMember = new global::designIdea002.designIdea002_XamlTypeInfo.XamlMember(this, "DefaultViewModel", "designIdea002.Common.ObservableDictionary");
                xamlMember.Getter = get_0_MainPage_DefaultViewModel;
                xamlMember.SetIsReadOnly();
                break;
            case "designIdea002.PdfPage.NavigationHelper":
                userType = (global::designIdea002.designIdea002_XamlTypeInfo.XamlUserType)GetXamlTypeByName("designIdea002.PdfPage");
                xamlMember = new global::designIdea002.designIdea002_XamlTypeInfo.XamlMember(this, "NavigationHelper", "designIdea002.Common.NavigationHelper");
                xamlMember.Getter = get_1_PdfPage_NavigationHelper;
                xamlMember.SetIsReadOnly();
                break;
            case "designIdea002.PdfPage.DefaultViewModel":
                userType = (global::designIdea002.designIdea002_XamlTypeInfo.XamlUserType)GetXamlTypeByName("designIdea002.PdfPage");
                xamlMember = new global::designIdea002.designIdea002_XamlTypeInfo.XamlMember(this, "DefaultViewModel", "designIdea002.Common.ObservableDictionary");
                xamlMember.Getter = get_2_PdfPage_DefaultViewModel;
                xamlMember.SetIsReadOnly();
                break;
            case "designIdea002.Profesori.DefaultViewModel":
                userType = (global::designIdea002.designIdea002_XamlTypeInfo.XamlUserType)GetXamlTypeByName("designIdea002.Profesori");
                xamlMember = new global::designIdea002.designIdea002_XamlTypeInfo.XamlMember(this, "DefaultViewModel", "designIdea002.Common.ObservableDictionary");
                xamlMember.Getter = get_3_Profesori_DefaultViewModel;
                xamlMember.SetIsReadOnly();
                break;
            case "designIdea002.Profesori.NavigationHelper":
                userType = (global::designIdea002.designIdea002_XamlTypeInfo.XamlUserType)GetXamlTypeByName("designIdea002.Profesori");
                xamlMember = new global::designIdea002.designIdea002_XamlTypeInfo.XamlMember(this, "NavigationHelper", "designIdea002.Common.NavigationHelper");
                xamlMember.Getter = get_4_Profesori_NavigationHelper;
                xamlMember.SetIsReadOnly();
                break;
            case "designIdea002.Studenti.idPageSent":
                userType = (global::designIdea002.designIdea002_XamlTypeInfo.XamlUserType)GetXamlTypeByName("designIdea002.Studenti");
                xamlMember = new global::designIdea002.designIdea002_XamlTypeInfo.XamlMember(this, "idPageSent", "Int32");
                xamlMember.Getter = get_5_Studenti_idPageSent;
                xamlMember.Setter = set_5_Studenti_idPageSent;
                break;
            }
            return xamlMember;
        }
    }

    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")]    
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class XamlSystemBaseType : global::Windows.UI.Xaml.Markup.IXamlType
    {
        string _fullName;
        global::System.Type _underlyingType;

        public XamlSystemBaseType(string fullName, global::System.Type underlyingType)
        {
            _fullName = fullName;
            _underlyingType = underlyingType;
        }

        public string FullName { get { return _fullName; } }

        public global::System.Type UnderlyingType
        {
            get
            {
                return _underlyingType;
            }
        }

        virtual public global::Windows.UI.Xaml.Markup.IXamlType BaseType { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlMember ContentProperty { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlMember GetMember(string name) { throw new global::System.NotImplementedException(); }
        virtual public bool IsArray { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsCollection { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsConstructible { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsDictionary { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsMarkupExtension { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsBindable { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsReturnTypeStub { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlType ItemType { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlType KeyType { get { throw new global::System.NotImplementedException(); } }
        virtual public object ActivateInstance() { throw new global::System.NotImplementedException(); }
        virtual public void AddToMap(object instance, object key, object item)  { throw new global::System.NotImplementedException(); }
        virtual public void AddToVector(object instance, object item)  { throw new global::System.NotImplementedException(); }
        virtual public void RunInitializer()   { throw new global::System.NotImplementedException(); }
        virtual public object CreateFromString(string input)   { throw new global::System.NotImplementedException(); }
    }
    
    internal delegate object Activator();
    internal delegate void AddToCollection(object instance, object item);
    internal delegate void AddToDictionary(object instance, object key, object item);

    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")]    
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class XamlUserType : global::designIdea002.designIdea002_XamlTypeInfo.XamlSystemBaseType
    {
        global::designIdea002.designIdea002_XamlTypeInfo.XamlTypeInfoProvider _provider;
        global::Windows.UI.Xaml.Markup.IXamlType _baseType;
        bool _isArray;
        bool _isMarkupExtension;
        bool _isBindable;
        bool _isReturnTypeStub;

        string _contentPropertyName;
        string _itemTypeName;
        string _keyTypeName;
        global::System.Collections.Generic.Dictionary<string, string> _memberNames;
        global::System.Collections.Generic.Dictionary<string, object> _enumValues;

        public XamlUserType(global::designIdea002.designIdea002_XamlTypeInfo.XamlTypeInfoProvider provider, string fullName, global::System.Type fullType, global::Windows.UI.Xaml.Markup.IXamlType baseType)
            :base(fullName, fullType)
        {
            _provider = provider;
            _baseType = baseType;
        }

        // --- Interface methods ----

        override public global::Windows.UI.Xaml.Markup.IXamlType BaseType { get { return _baseType; } }
        override public bool IsArray { get { return _isArray; } }
        override public bool IsCollection { get { return (CollectionAdd != null); } }
        override public bool IsConstructible { get { return (Activator != null); } }
        override public bool IsDictionary { get { return (DictionaryAdd != null); } }
        override public bool IsMarkupExtension { get { return _isMarkupExtension; } }
        override public bool IsBindable { get { return _isBindable; } }
        override public bool IsReturnTypeStub { get { return _isReturnTypeStub; } }

        override public global::Windows.UI.Xaml.Markup.IXamlMember ContentProperty
        {
            get { return _provider.GetMemberByLongName(_contentPropertyName); }
        }

        override public global::Windows.UI.Xaml.Markup.IXamlType ItemType
        {
            get { return _provider.GetXamlTypeByName(_itemTypeName); }
        }

        override public global::Windows.UI.Xaml.Markup.IXamlType KeyType
        {
            get { return _provider.GetXamlTypeByName(_keyTypeName); }
        }

        override public global::Windows.UI.Xaml.Markup.IXamlMember GetMember(string name)
        {
            if (_memberNames == null)
            {
                return null;
            }
            string longName;
            if (_memberNames.TryGetValue(name, out longName))
            {
                return _provider.GetMemberByLongName(longName);
            }
            return null;
        }

        override public object ActivateInstance()
        {
            return Activator(); 
        }

        override public void AddToMap(object instance, object key, object item) 
        {
            DictionaryAdd(instance, key, item);
        }

        override public void AddToVector(object instance, object item)
        {
            CollectionAdd(instance, item);
        }

        override public void RunInitializer() 
        {
            System.Runtime.CompilerServices.RuntimeHelpers.RunClassConstructor(UnderlyingType.TypeHandle);
        }

        override public object CreateFromString(string input)
        {
            if (_enumValues != null)
            {
                int value = 0;

                string[] valueParts = input.Split(',');

                foreach (string valuePart in valueParts) 
                {
                    object partValue;
                    int enumFieldValue = 0;
                    try
                    {
                        if (_enumValues.TryGetValue(valuePart.Trim(), out partValue))
                        {
                            enumFieldValue = global::System.Convert.ToInt32(partValue);
                        }
                        else
                        {
                            try
                            {
                                enumFieldValue = global::System.Convert.ToInt32(valuePart.Trim());
                            }
                            catch( global::System.FormatException )
                            {
                                foreach( string key in _enumValues.Keys )
                                {
                                    if( string.Compare(valuePart.Trim(), key, global::System.StringComparison.OrdinalIgnoreCase) == 0 )
                                    {
                                        if( _enumValues.TryGetValue(key.Trim(), out partValue) )
                                        {
                                            enumFieldValue = global::System.Convert.ToInt32(partValue);
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                        value |= enumFieldValue; 
                    }
                    catch( global::System.FormatException )
                    {
                        throw new global::System.ArgumentException(input, FullName);
                    }
                }

                return value; 
            }
            throw new global::System.ArgumentException(input, FullName);
        }

        // --- End of Interface methods

        public Activator Activator { get; set; }
        public AddToCollection CollectionAdd { get; set; }
        public AddToDictionary DictionaryAdd { get; set; }

        public void SetContentPropertyName(string contentPropertyName)
        {
            _contentPropertyName = contentPropertyName;
        }

        public void SetIsArray()
        {
            _isArray = true; 
        }

        public void SetIsMarkupExtension()
        {
            _isMarkupExtension = true;
        }

        public void SetIsBindable()
        {
            _isBindable = true;
        }

        public void SetIsReturnTypeStub()
        {
            _isReturnTypeStub = true;
        }

        public void SetItemTypeName(string itemTypeName)
        {
            _itemTypeName = itemTypeName;
        }

        public void SetKeyTypeName(string keyTypeName)
        {
            _keyTypeName = keyTypeName;
        }

        public void AddMemberName(string shortName)
        {
            if(_memberNames == null)
            {
                _memberNames =  new global::System.Collections.Generic.Dictionary<string,string>();
            }
            _memberNames.Add(shortName, FullName + "." + shortName);
        }

        public void AddEnumValue(string name, object value)
        {
            if (_enumValues == null)
            {
                _enumValues = new global::System.Collections.Generic.Dictionary<string, object>();
            }
            _enumValues.Add(name, value);
        }
    }

    internal delegate object Getter(object instance);
    internal delegate void Setter(object instance, object value);

    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")]    
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class XamlMember : global::Windows.UI.Xaml.Markup.IXamlMember
    {
        global::designIdea002.designIdea002_XamlTypeInfo.XamlTypeInfoProvider _provider;
        string _name;
        bool _isAttachable;
        bool _isDependencyProperty;
        bool _isReadOnly;

        string _typeName;
        string _targetTypeName;

        public XamlMember(global::designIdea002.designIdea002_XamlTypeInfo.XamlTypeInfoProvider provider, string name, string typeName)
        {
            _name = name;
            _typeName = typeName;
            _provider = provider;
        }

        public string Name { get { return _name; } }

        public global::Windows.UI.Xaml.Markup.IXamlType Type
        {
            get { return _provider.GetXamlTypeByName(_typeName); }
        }

        public void SetTargetTypeName(string targetTypeName)
        {
            _targetTypeName = targetTypeName;
        }
        public global::Windows.UI.Xaml.Markup.IXamlType TargetType
        {
            get { return _provider.GetXamlTypeByName(_targetTypeName); }
        }

        public void SetIsAttachable() { _isAttachable = true; }
        public bool IsAttachable { get { return _isAttachable; } }

        public void SetIsDependencyProperty() { _isDependencyProperty = true; }
        public bool IsDependencyProperty { get { return _isDependencyProperty; } }

        public void SetIsReadOnly() { _isReadOnly = true; }
        public bool IsReadOnly { get { return _isReadOnly; } }

        public Getter Getter { get; set; }
        public object GetValue(object instance)
        {
            if (Getter != null)
                return Getter(instance);
            else
                throw new global::System.InvalidOperationException("GetValue");
        }

        public Setter Setter { get; set; }
        public void SetValue(object instance, object value)
        {
            if (Setter != null)
                Setter(instance, value);
            else
                throw new global::System.InvalidOperationException("SetValue");
        }
    }
}


