//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MimAcher.Infra
{
    using System;
    using System.Collections.Generic;
    
    public partial class MA_NAC_AREA_ATUACAO
    {
        public int cod_nac_area_atuacao { get; set; }
        public int cod_nac { get; set; }
        public int cod_area_atuacao { get; set; }
    
        public virtual MA_AREA_ATUACAO MA_AREA_ATUACAO { get; set; }
        public virtual MA_NAC MA_NAC { get; set; }
    }
}