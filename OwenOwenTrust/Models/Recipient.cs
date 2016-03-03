namespace OwenOwenTrust
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oot.recipients")]
    public partial class recipient
    {
        public int ID { get; set; }

        [StringLength(8)]
        public string PID { get; set; }

        public short? Class { get; set; }

        [StringLength(1)]
        public string Group { get; set; }

        public int? PayNo { get; set; }

        [StringLength(1)]
        public string PayMethod { get; set; }

        [StringLength(27)]
        public string LastName { get; set; }

        [StringLength(8)]
        public string Firstnames { get; set; }

        public int? StoreNo { get; set; }

        [StringLength(4)]
        public string Title { get; set; }

        [StringLength(1)]
        public string Sex { get; set; }

        [StringLength(3)]
        public string Status { get; set; }

        public DateTime? DOB { get; set; }

        public double? Age { get; set; }

        [StringLength(15)]
        public string StoreName { get; set; }

        [StringLength(30)]
        public string Present { get; set; }

        [StringLength(30)]
        public string Previous { get; set; }

        [StringLength(30)]
        public string Add1 { get; set; }

        [StringLength(30)]
        public string Addb1 { get; set; }

        [StringLength(30)]
        public string Add2 { get; set; }

        [StringLength(30)]
        public string Addb2 { get; set; }

        [StringLength(30)]
        public string Add3 { get; set; }

        [StringLength(30)]
        public string Addb3 { get; set; }

        [StringLength(30)]
        public string Add4 { get; set; }

        [StringLength(30)]
        public string Addb4 { get; set; }

        [StringLength(30)]
        public string PC1 { get; set; }

        [StringLength(30)]
        public string PC2 { get; set; }

        [StringLength(15)]
        public string Tel { get; set; }

        public DateTime? DateofChange { get; set; }

        public byte AppEmp { get; set; }

        public byte RelEmp { get; set; }

        public DateTime? EmpDate { get; set; }

        public DateTime? DOL { get; set; }

        public double? Service { get; set; }

        [StringLength(30)]
        public string MName { get; set; }

        public byte EmpProof { get; set; }

        [StringLength(8)]
        public string SID { get; set; }

        public DateTime? SEmpDate { get; set; }

        public DateTime? SDOL { get; set; }

        public double? SService { get; set; }

        public DateTime? EnqFrom { get; set; }

        public DateTime? InitLet { get; set; }

        public DateTime? InitBac { get; set; }

        [StringLength(10)]
        public string LetType { get; set; }

        public DateTime? DOI { get; set; }

        public byte SPDetail { get; set; }

        [StringLength(200)]
        public string Comments { get; set; }

        public DateTime? DPC { get; set; }

        public byte Commuted { get; set; }

        public DateTime? DOD { get; set; }

        public DateTime? DON { get; set; }

        public double? SP { get; set; }

        public double? OOP { get; set; }

        public double? OP { get; set; }

        public double? UB { get; set; }

        public double? WS { get; set; }

        public double? IS { get; set; }

        public double? OI { get; set; }

        public double? ISup { get; set; }

        public double? TotI { get; set; }

        public byte DIS { get; set; }

        public double? AA { get; set; }

        public double? DL { get; set; }

        public byte HBx { get; set; }

        public double? HB { get; set; }

        public byte OTT { get; set; }

        public byte IncSupx { get; set; }

        public double? IncSup { get; set; }

        public byte HO { get; set; }

        [StringLength(6)]
        public string HORent { get; set; }

        public double? RENT { get; set; }

        [StringLength(50)]
        public string RNH { get; set; }

        [StringLength(50)]
        public string RHH { get; set; }

        public double? HHCost { get; set; }

        public DateTime? DOT2ISS { get; set; }

        public DateTime? DOT2REC { get; set; }

        public DateTime? DILISS { get; set; }

        public DateTime? DILREC { get; set; }

        [StringLength(60)]
        public string RWNG { get; set; }

        public byte RED { get; set; }

        [StringLength(255)]
        public string RWRED { get; set; }

        public byte RESH { get; set; }

        [StringLength(255)]
        public string RED2 { get; set; }

        public byte SG { get; set; }

        [StringLength(255)]
        public string RWSG { get; set; }

        public DateTime? InfChg { get; set; }

        public DateTime? DBankDReq { get; set; }

        public DateTime? DBankDRec { get; set; }

        public double? ValGP { get; set; }

        public DateTime? DtoLCSS { get; set; }

        public DateTime? DOGP { get; set; }

        public DateTime? DOGP2 { get; set; }

        public DateTime? DOGP3 { get; set; }

        public DateTime? DOGP4 { get; set; }

        public double? Value2 { get; set; }

        public double? PbyP { get; set; }

        [StringLength(15)]
        public string Period { get; set; }

        public DateTime? Commence { get; set; }

        [StringLength(1)]
        public string BBS { get; set; }

        [StringLength(25)]
        public string Bank1 { get; set; }

        [StringLength(25)]
        public string Bank2 { get; set; }

        [StringLength(25)]
        public string Bank3 { get; set; }

        [StringLength(25)]
        public string Bank4 { get; set; }

        [StringLength(20)]
        public string BPC { get; set; }

        [StringLength(10)]
        public string SortCode { get; set; }

        [StringLength(12)]
        public string ACCTNo { get; set; }

        [StringLength(14)]
        public string REFNo { get; set; }

        [StringLength(25)]
        public string BSRef { get; set; }

        [StringLength(50)]
        public string OGE { get; set; }

        public DateTime? DFGP { get; set; }

        [StringLength(20)]
        public string FGPApp { get; set; }

        public double? FGP { get; set; }

        [StringLength(6)]
        public string FGPChq { get; set; }

        public byte XmasGift { get; set; }

        public byte XmasToken { get; set; }

        [StringLength(40)]
        public string NOK { get; set; }

        [StringLength(15)]
        public string NOKTel { get; set; }

        public short? Visitor { get; set; }

        public short? VPrev { get; set; }

        public DateTime? VChange { get; set; }

        [StringLength(10)]
        public string VType { get; set; }

        [StringLength(30)]
        public string CS { get; set; }

        [StringLength(3)]
        public string FLX { get; set; }

        public short? FL { get; set; }

        public short? Ded { get; set; }

        [StringLength(5)]
        public string User { get; set; }

        [StringLength(15)]
        public string Rel { get; set; }

        public DateTime? ChqPD { get; set; }

        public byte CTaxYN { get; set; }

        public double? CTaxBfit { get; set; }

        public double? Water { get; set; }

        public double? OthExp { get; set; }

        public double? GRent { get; set; }

        public double? PropSrv { get; set; }

        public double? OthBfit { get; set; }

        public byte A { get; set; }

        public DateTime? AD { get; set; }

        public byte GPS { get; set; }

        public byte SDapp { get; set; }

        public double? NDT { get; set; }

        public byte ReApp { get; set; }

        [StringLength(10)]
        public string AccStatus { get; set; }

        public double? TotBenefit { get; set; }

        public double? NetOutgoing { get; set; }

        public double? NetBenefit1 { get; set; }

        public double? NetBenefit2 { get; set; }

        public double? NetDiff { get; set; }

    }

    //for searching
    public partial class recipientsearch
    {
        [Display(Name = "ID No.")]
        public string PID { get; set; }
        
        [Display(Name = "Group")]
        public string Group { get; set; }


        [Display(Name = "Last name")]
        public string LastName { get; set; }

        [Display(Name = "Initials")]
        public string Firstnames { get; set; }

        [Display(Name = "Store")]
        public int? StoreNo { get; set; }

        [Display(Name = "Sex")]
        public string Sex { get; set; }

        [Display(Name = "Status")]
        public string Status { get; set; }

        [Display(Name = "Age")]
        public double? Age { get; set; }

        public IEnumerable<recipient> recipients;

        public string sortorder { get; set; }
    }
    //end recipient search
}
