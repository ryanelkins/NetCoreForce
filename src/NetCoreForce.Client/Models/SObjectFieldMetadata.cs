
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NetCoreForce.Client.Models
{
    public class SObjectFieldMetadata
    {
        [JsonProperty(PropertyName = "aggregatable")]
        public bool Aggregatable { get; set; }
        
        [JsonProperty(PropertyName = "aiPredictionField")]
        public bool AiPredictionField { get; set; }
        
        [JsonProperty(PropertyName = "autoNumber")]
        public bool AutoNumber { get; set; }
        
        [JsonProperty(PropertyName = "byteLength")]
        public int ByteLength { get; set; }

        [JsonProperty(PropertyName = "calculated")]
        public bool Calculated { get; set; }
        
        [JsonProperty(PropertyName = "calculatedFormula")]
        public bool CalculatedFormula { get; set; }
        
        [JsonProperty(PropertyName = "caseSensitive")]
        public bool CaseSensitive { get; set; }
        
        //[JsonProperty(PropertyName = "compoundFieldName")]
        //public ? CompoundFieldName { get; set; }
        
        [JsonProperty(PropertyName = "controllerName")]
        public string ControllerName { get; set; }

        [JsonProperty(PropertyName = "createable")]
        public bool Creatable { get; set; }

        [JsonProperty(PropertyName = "custom")]
        public bool Custom { get; set; }
        
        [JsonProperty(PropertyName = "defaultedOnCreate")]
        public bool DefaultedOnCreate { get; set; }

        [JsonProperty(PropertyName = "defaultValue")]
        public string DefaultValue { get; set; }
        
        [JsonProperty(PropertyName = "defaultValueFormula")]
        public string DefaultValueFormula { get; set; }
        
        [JsonProperty(PropertyName = "defaultedOnCreate")]
        public bool DefaultedOnCreate { get; set; }
        
        [JsonProperty(PropertyName = "dependentPicklist")]
        public bool DependentPicklist { get; set; }
        
        [JsonProperty(PropertyName = "deprecatedAndHidden")]
        public bool DeprecatedAndHidden { get; set; }
    
        [JsonProperty(PropertyName = "digits")]
        public int Digits { get; set; }
   
        [JsonProperty(PropertyName = "displayLocationInDecimal")]
        public bool DisplayLocationInDecimal { get; set; }

        [JsonProperty(PropertyName = "encrypted")]
        public bool Encrypted { get; set; }
    
        [JsonProperty(PropertyName = "externalId")]
        public string ExternalId { get; set; }
        
        [JsonProperty(PropertyName = "extraTypeInfo")]
        public string ExtraTypeInfo { get; set; }
        
        [JsonProperty(PropertyName = "filterable")]
        public bool Filterable { get; set; }
        
        //[JsonProperty(PropertyName = "filteredLookupInfo")]
        //public string FilteredLookupInfo { get; set; }
        
        [JsonProperty(PropertyName = "formulaTreatNullNumberAsZero")]
        public string FormulaTreatNullNumberAsZero { get; set; }
        
        [JsonProperty(PropertyName = "groupable")]
        public bool Groupable { get; set; }
        
        [JsonProperty(PropertyName = "highScaleNumber")]
        public bool HighScaleNumber { get; set; }

        [JsonProperty(PropertyName = "htmlFormatted")]
        public bool HtmlFormatted { get; set; }
        
        [JsonProperty(PropertyName = "idLookup")]
        public bool IdLookup { get; set; }
        
        [JsonProperty(PropertyName = "inlineHelpText")]
        public string InlineHelpText { get; set; }

        [JsonProperty(PropertyName = "label")]
        public string Label { get; set; }

        [JsonProperty(PropertyName = "length")]
        public int Length { get; set; }        

        [JsonProperty(PropertyName = "mask")]
        public string Mask { get; set; }        

        [JsonProperty(PropertyName = "maskType")]
        public string MaskType { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }        

        [JsonProperty(PropertyName = "nameField")]
        public bool NameField { get; set; }        

        [JsonProperty(PropertyName = "namePointing")]
        public bool NamePointing { get; set; }

        [JsonProperty(PropertyName = "nillable")]
        public bool Nillable { get; set; }

        [JsonProperty(PropertyName = "permissionable")]
        public bool Permissionable { get; set; }
        
        [JsonProperty(PropertyName = "picklistValues")]
        public List<PickListValue> PicklistValues { get; set; }
                
        [JsonProperty(PropertyName = "polymorphicForeignKey")]
        public bool PolymorphicForeignKey { get; set; }
   
        [JsonProperty(PropertyName = "precision")]
        public int Precision { get; set; }
        
        [JsonProperty(PropertyName = "queryByDistance")]
        public bool QueryByDistance { get; set; }
        
        [JsonProperty(PropertyName = "referenceTargetField")]
        public string ReferenceTargetField { get; set; }

        [JsonProperty(PropertyName = "referenceTo")]
        public List<string> ReferenceTo { get; set; }

        [JsonProperty(PropertyName = "relationshipName")]
        public string RelationshipName { get; set; }
        
        [JsonProperty(PropertyName = "relationshipOrder")]
        public int RelationshipOrder { get; set; }
        
        [JsonProperty(PropertyName = "restrictedDelete")]
        public bool RestrictedDelete { get; set; }
        
        [JsonProperty(PropertyName = "restrictedPicklist")]
        public bool RestrictedPicklist { get; set; }
        
        [JsonProperty(PropertyName = "scale")]
        public int Scale { get; set; }        
    
        [JsonProperty(PropertyName = "searchPrefilterable")]
        public bool SearchPrefilterable { get; set; }
        
        //[JsonProperty(PropertyName = "soapType")]
        //public string SoapType { get; set; }

        [JsonProperty(PropertyName = "sortable")]
        public bool Sortable { get; set; }

        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }        

        [JsonProperty(PropertyName = "unique")]
        public bool Unique { get; set; }   

        [JsonProperty(PropertyName = "updateable")]
        public bool Updateable { get; set; }        

        [JsonProperty(PropertyName = "writeRequiresMasterRead")]
        public bool WriteRequiresMasterRead { get; set; }
    }
}
