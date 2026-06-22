using System;
using System.Collections.Generic;

namespace EasyLab.Models;

public partial class ImpOrdiniPfjoorNormalizz
{
    public int Id { get; set; }

    public int? IdContatto { get; set; }

    public int? IdCcli { get; set; }

    public int? IdCcliDest { get; set; }

    public int? IdStag { get; set; }

    public int? IdMod { get; set; }

    public int? IdModCol { get; set; }

    public int? IdModNoStag { get; set; }

    public int? IdModColNoStag { get; set; }

    public int? IdPag { get; set; }

    public string? Mod { get; set; }

    public string? Tess { get; set; }

    public int? SetPos { get; set; }

    public string? CdValuta { get; set; }

    public string? OrderNr { get; set; }

    public DateOnly? OrderDate { get; set; }

    public int? SetOrd { get; set; }

    public string? LinesheetName { get; set; }

    public string? StyleNumber { get; set; }

    public string? StyleName { get; set; }

    public string? ColorName { get; set; }

    public string? ColorCode { get; set; }

    public string? Fabrication { get; set; }

    public string? FabricationCode { get; set; }

    public string? Silhouette { get; set; }

    public string? SilhouetteCode { get; set; }

    public string? Materials { get; set; }

    public string? Measurments { get; set; }

    public string? CountryOfOrigin { get; set; }

    public string? WarehouseName { get; set; }

    public string? WarehouseCode { get; set; }

    public string? CustomerCode { get; set; }

    public string? Po { get; set; }

    public string? OrderType { get; set; }

    public string? DoorNames { get; set; }

    public string? DoorName { get; set; }

    public string? DoorCode { get; set; }

    public string? ShippingMethodName { get; set; }

    public string? ShippingMethodCode { get; set; }

    public string? PaymentMethodName { get; set; }

    public string? PaymentMethodCode { get; set; }

    public string? PriceLabel { get; set; }

    public double? SizeOriginalPrice { get; set; }

    public double? SizePrice { get; set; }

    public double? RetailPrice { get; set; }

    public DateOnly? StartShip { get; set; }

    public DateOnly? CompleteShip { get; set; }

    public string? ShippingCountry { get; set; }

    public string? ShippingState { get; set; }

    public string? ShippingCity { get; set; }

    public string? BuyerName { get; set; }

    public string? OrderStatus { get; set; }

    public string? SalesRepName { get; set; }

    public string? SalesRepCode { get; set; }

    public string? OrderSeasonName { get; set; }

    public string? OrderSeasonCode { get; set; }

    public string? OrderSeasonYear { get; set; }

    public string? SizeName { get; set; }

    public string? SizeCode { get; set; }

    public int? Units { get; set; }

    public string? OrderComment { get; set; }

    public int? IdTipoList { get; set; }

    public int? IdSetGroup { get; set; }

    public int? IdSet { get; set; }

    public int? IdErpOrd { get; set; }

    public int? ShippingCode { get; set; }

    public int? IdRagg1 { get; set; }

    public int? IdRagg2 { get; set; }

    public int? IdRagg3 { get; set; }

    public int? IdRagg4 { get; set; }

    public int? IdRagg5 { get; set; }

    public int? IdRagg6 { get; set; }

    public int? IdDdtResa { get; set; }

    public int? TotalUnits { get; set; }

    public double? OrderTotal { get; set; }

    public int? IdLineSheet { get; set; }

    public string? CdMag { get; set; }

    public string? OrdTipo { get; set; }

    public double? DiscountPercent { get; set; }
}
