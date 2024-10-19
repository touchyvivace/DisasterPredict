using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Domain.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum DisasterType
    {
        [EnumMember(Value = "flood")]
        [Display(Name = "Flood", Description = "Flood Type")]
        Flood,
        [EnumMember(Value = "wildfire")]
        [Display(Name = "Wildfire", Description = "")]
        Wildfire,
        [EnumMember(Value = "earthquake")]
        [Display(Name = "Earthquake", Description = "")]
        Earthquake,
        [EnumMember(Value = "hurricane")]
        [Display(Name = "Hurricane", Description = "")]
        Hurricane,
        [EnumMember(Value = "tsunami")]
        [Display(Name = "Tsunami", Description = "")]
        Tsunami,
        [EnumMember(Value = "tornado")]
        [Display(Name = "Tornado", Description = "")]
        Tornado,
        [EnumMember(Value = "avalanche")]
        [Display(Name = "Avalanche", Description = "")]
        Avalanche,
        [EnumMember(Value = "drought")]
        [Display(Name = "Drought", Description = "")]
        Drought,
        [EnumMember(Value = "extremeHeat")]
        [Display(Name = "ExtremeHeat", Description = "")]
        ExtremeHeat,
        [EnumMember(Value = "landslide")]
        [Display(Name = "Landslide", Description = "")]
        Landslide,
        [EnumMember(Value = "pandemic")]
        [Display(Name = "Pandemic", Description = "")]
        Pandemic,
        [EnumMember(Value = "storm")]
        [Display(Name = "Storm", Description = "")]
        Storm,
        [EnumMember(Value = "volcanoes")]
        [Display(Name = "Volcanoes", Description = "")]
        Volcanoes
    }
}