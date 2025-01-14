﻿using System.ComponentModel.DataAnnotations;

namespace Leasy.API.Reports.Resources;

public class SaveReportResource
{
    [Required]
    public decimal AssetPrice { get; set; }
    
    [Required]
    public int LeasingYears { get; set; }
    
    [Required]
    public string PaymentFrequency { get; set; }
    
    [Required]
    public string RateType { get; set; }
    
    [Required]
    public decimal RateValue { get; set; }
    
    [Required]
    public string RateFrequency { get; set; }
    
    public string Capitalization { get; set; }
    
    public decimal Buyback { get; set; }
    public decimal NotaryFees { get; set; }
    public decimal RegistryFees { get; set; }
    public decimal Valuation { get; set; }
    public decimal StudyCommission { get; set; }
    public decimal ActivationCommission { get; set; }
    public decimal RegularCommission { get; set; }
    public decimal RiskInsurance { get; set; }
    
    [Required]
    public decimal RateKs { get; set; }
    
    [Required]
    public decimal RateWacc {get; set; }
    
    [Required]
    public int UserId { get; set; }
}