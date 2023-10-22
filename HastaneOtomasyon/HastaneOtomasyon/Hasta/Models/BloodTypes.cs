using System.ComponentModel;

namespace HastaneOtomasyon.Hasta.Models
{
    public enum BloodTypes
    {
        [Description("--- Kan Grubu seçiniz ---")] None,
        [Description("A Rh +")] AP,
        [Description("A Rh -")] AN,
        [Description("B Rh +")] BP,
        [Description("B Rh -")] BN,
        [Description("AB Rh +")] ABP,
        [Description("AB Rh -")] ABN,
        [Description("0 Rh +")] ZP,
        [Description("0 Rh -")] ZN
    }
}
