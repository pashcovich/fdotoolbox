﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.4952
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by xsd, Version=2.0.50727.3038.
// 
namespace FdoToolbox.Core.Configuration {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("BulkCopy", Namespace="", IsNullable=false)]
    public partial class FdoBulkCopyTaskDefinition {
        
        private FdoConnectionEntryElement[] connectionsField;
        
        private FdoCopyTaskElement[] copyTasksField;
        
        private string nameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Connection", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public FdoConnectionEntryElement[] Connections {
            get {
                return this.connectionsField;
            }
            set {
                this.connectionsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("CopyTask", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public FdoCopyTaskElement[] CopyTasks {
            get {
                return this.copyTasksField;
            }
            set {
                this.copyTasksField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class FdoConnectionEntryElement {
        
        private string connectionStringField;
        
        private string nameField;
        
        private string providerField;
        
        private string configPathField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ConnectionString {
            get {
                return this.connectionStringField;
            }
            set {
                this.connectionStringField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string provider {
            get {
                return this.providerField;
            }
            set {
                this.providerField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string configPath {
            get {
                return this.configPathField;
            }
            set {
                this.configPathField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class FdoExpressionMappingElement {
        
        private string expressionField;
        
        private string aliasField;
        
        private string targetField;
        
        private bool nullOnFailedConversionField;
        
        private bool truncateField;
        
        private bool createIfNotExistsField;
        
        public FdoExpressionMappingElement() {
            this.nullOnFailedConversionField = true;
            this.truncateField = true;
            this.createIfNotExistsField = false;
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Expression {
            get {
                return this.expressionField;
            }
            set {
                this.expressionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string alias {
            get {
                return this.aliasField;
            }
            set {
                this.aliasField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string target {
            get {
                return this.targetField;
            }
            set {
                this.targetField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool nullOnFailedConversion {
            get {
                return this.nullOnFailedConversionField;
            }
            set {
                this.nullOnFailedConversionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool truncate {
            get {
                return this.truncateField;
            }
            set {
                this.truncateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool createIfNotExists {
            get {
                return this.createIfNotExistsField;
            }
            set {
                this.createIfNotExistsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class FdoPropertyMappingElement {
        
        private string sourceField;
        
        private string targetField;
        
        private bool nullOnFailedConversionField;
        
        private bool truncateField;
        
        private bool createIfNotExistsField;
        
        public FdoPropertyMappingElement() {
            this.nullOnFailedConversionField = true;
            this.truncateField = true;
            this.createIfNotExistsField = false;
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string source {
            get {
                return this.sourceField;
            }
            set {
                this.sourceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string target {
            get {
                return this.targetField;
            }
            set {
                this.targetField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool nullOnFailedConversion {
            get {
                return this.nullOnFailedConversionField;
            }
            set {
                this.nullOnFailedConversionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool truncate {
            get {
                return this.truncateField;
            }
            set {
                this.truncateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool createIfNotExists {
            get {
                return this.createIfNotExistsField;
            }
            set {
                this.createIfNotExistsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class FdoCopyOptionsElement {
        
        private bool deleteTargetField;
        
        private string filterField;
        
        private bool flattenGeometriesField;
        
        private bool flattenGeometriesFieldSpecified;
        
        private string batchSizeField;
        
        private bool forceWKBField;
        
        private bool forceWKBFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool DeleteTarget {
            get {
                return this.deleteTargetField;
            }
            set {
                this.deleteTargetField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string Filter {
            get {
                return this.filterField;
            }
            set {
                this.filterField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool FlattenGeometries {
            get {
                return this.flattenGeometriesField;
            }
            set {
                this.flattenGeometriesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FlattenGeometriesSpecified {
            get {
                return this.flattenGeometriesFieldSpecified;
            }
            set {
                this.flattenGeometriesFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="integer")]
        public string BatchSize {
            get {
                return this.batchSizeField;
            }
            set {
                this.batchSizeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public bool ForceWKB {
            get {
                return this.forceWKBField;
            }
            set {
                this.forceWKBField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ForceWKBSpecified {
            get {
                return this.forceWKBFieldSpecified;
            }
            set {
                this.forceWKBFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class FdoCopyTargetElement {
        
        private string connectionField;
        
        private string schemaField;
        
        private string classField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string connection {
            get {
                return this.connectionField;
            }
            set {
                this.connectionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string schema {
            get {
                return this.schemaField;
            }
            set {
                this.schemaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string @class {
            get {
                return this.classField;
            }
            set {
                this.classField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class FdoCopySourceElement {
        
        private string connectionField;
        
        private string schemaField;
        
        private string classField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string connection {
            get {
                return this.connectionField;
            }
            set {
                this.connectionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string schema {
            get {
                return this.schemaField;
            }
            set {
                this.schemaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string @class {
            get {
                return this.classField;
            }
            set {
                this.classField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class FdoCopyTaskElement {
        
        private FdoCopySourceElement sourceField;
        
        private FdoCopyTargetElement targetField;
        
        private FdoCopyOptionsElement optionsField;
        
        private FdoPropertyMappingElement[] propertyMappingsField;
        
        private FdoExpressionMappingElement[] expressionMappingsField;
        
        private string nameField;
        
        private bool createIfNotExistsField;
        
        public FdoCopyTaskElement() {
            this.createIfNotExistsField = false;
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public FdoCopySourceElement Source {
            get {
                return this.sourceField;
            }
            set {
                this.sourceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public FdoCopyTargetElement Target {
            get {
                return this.targetField;
            }
            set {
                this.targetField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public FdoCopyOptionsElement Options {
            get {
                return this.optionsField;
            }
            set {
                this.optionsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("PropertyMapping", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public FdoPropertyMappingElement[] PropertyMappings {
            get {
                return this.propertyMappingsField;
            }
            set {
                this.propertyMappingsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("ExpressionMapping", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=false)]
        public FdoExpressionMappingElement[] ExpressionMappings {
            get {
                return this.expressionMappingsField;
            }
            set {
                this.expressionMappingsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool createIfNotExists {
            get {
                return this.createIfNotExistsField;
            }
            set {
                this.createIfNotExistsField = value;
            }
        }
    }
}
