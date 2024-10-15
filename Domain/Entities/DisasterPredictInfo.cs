using System.ComponentModel.DataAnnotations;

namespace DisasterPredict.Domain.Entities;
public class DisasterPredictInfo : BaseAuditableEntity
{


    [Required(ErrorMessage = "Name field is required DisasterPredictName!")]
    public string DisasterPredictName { get; set; }

    [Required(ErrorMessage = "Name field is required DisasterPredictType!")]
    public string DisasterPredictType { get; set; }

    [Required(ErrorMessage = "Name field is required Speed!")]
    [Range(0, 9999, ErrorMessage = "Type formatting is wrong number")]
    public int Speed { get; set; }


}
