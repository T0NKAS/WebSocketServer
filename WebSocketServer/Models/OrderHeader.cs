using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebSocketServer.Models
{
    public class OrderHeader
    {
        public string CompanyID { get; set; }
        public string DivisionID { get; set; }
        public string DepartmentID { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string OrderNumber { get; set; }

        public string TransactionTypeID { get; set; }
        public string OrderTypeID { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? OrderDate { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? OrderDueDate { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? OrderShipDate { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? OrderCancelDate { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? SystemDate { get; set; }

        public bool? Memorize { get; set; }
        public string PurchaseOrderNumber { get; set; }
        public string TaxExemptID { get; set; }
        public string TaxGroupID { get; set; }
        public string CustomerID { get; set; }
        public string TermsID { get; set; }
        public string CurrencyID { get; set; }
        public double? CurrencyExchangeRate { get; set; }
        public decimal? Subtotal { get; set; }
        public double? DiscountPers { get; set; }
        public decimal? DiscountAmount { get; set; }
        public double? TaxPercent { get; set; }
        public decimal? TaxAmount { get; set; }
        public decimal? TaxableSubTotal { get; set; }
        public decimal? Freight { get; set; }
        public bool? TaxFreight { get; set; }
        public decimal? Handling { get; set; }
        public decimal? Advertising { get; set; }
        public decimal? Total { get; set; }
        public string EmployeeID { get; set; }
        public decimal? Commission { get; set; }
        public decimal? CommissionableSales { get; set; }
        public decimal? ComissionalbleCost { get; set; }
        public bool? CustomerDropShipment { get; set; }
        public string ShipMethodID { get; set; }
        public string WarehouseID { get; set; }
        public string ShipToID { get; set; }
        public string ShipForID { get; set; }
        public string ShippingName { get; set; }
        public string ShippingAddress1 { get; set; }
        public string ShippingAddress2 { get; set; }
        public string ShippingAddress3 { get; set; }
        public string ShippingCity { get; set; }
        public string ShippingState { get; set; }
        public string ShippingZip { get; set; }
        public string ShippingCountry { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? ScheduledStartDate { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? ScheduledEndDate { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? ServiceStartDate { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? ServiceEndDate { get; set; }

        public string PerformedBy { get; set; }
        public string GLSalesAccount { get; set; }
        public string PaymentMethodID { get; set; }
        public decimal? AmountPaid { get; set; }
        public decimal? BalanceDue { get; set; }
        public decimal? UndistributedAmount { get; set; }
        public string CheckNumber { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? CheckDate { get; set; }

        public string CreditCardTypeID { get; set; }
        public string CreditCardName { get; set; }
        public string CreditCardNumber { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? CreditCardExpDate { get; set; }

        public string CreditCardCSVNumber { get; set; }
        public string CreditCardBillToZip { get; set; }
        public string CreditCardValidationCode { get; set; }
        public string CreditCardApprovalNumber { get; set; }
        public bool? Backordered { get; set; }
        public bool? Picked { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? PickedDate { get; set; }

        public bool? Printed { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? PrintedDate { get; set; }

        public bool? Shipped { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? ShipDate { get; set; }

        public string TrackingNumber { get; set; }
        public bool? Billed { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? BilledDate { get; set; }

        public bool? Invoiced { get; set; }
        public string InvoiceNumber { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? InvoiceDate { get; set; }

        public bool? Posted { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? PostedDate { get; set; }

        public double? AllowanceDiscountPerc { get; set; }
        public decimal? CashTendered { get; set; }
        public string MasterBillOfLading { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? MasterBillOfLadingDate { get; set; }

        public string TrailerNumber { get; set; }
        public string TrailerPrefix { get; set; }
        public string HeaderMemo1 { get; set; }
        public string HeaderMemo2 { get; set; }
        public string HeaderMemo3 { get; set; }
        public string HeaderMemo4 { get; set; }
        public string HeaderMemo5 { get; set; }
        public string HeaderMemo6 { get; set; }
        public string HeaderMemo7 { get; set; }
        public string HeaderMemo8 { get; set; }
        public string HeaderMemo9 { get; set; }
        public bool? Approved { get; set; }
        public string ApprovedBy { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? ApprovedDate { get; set; }

        public string EnteredBy { get; set; }
        public string Signature { get; set; }
        public string SignaturePassword { get; set; }
        public string SupervisorSignature { get; set; }
        public string SupervisorPassword { get; set; }
        public string ManagerSignature { get; set; }
        public string ManagerPassword { get; set; }
        public bool? Remisioned { get; set; }
        public string RemisionNumber { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? RemisionDate { get; set; }

        public bool? Remisionar { get; set; }
        public bool? Facturar { get; set; }
        public string Leyenda { get; set; }
        public bool? ASN { get; set; }
        public double? GrossWeight { get; set; }
        public string ContType { get; set; }
        public int? NoOfCont { get; set; }
        public string SCAC { get; set; }
        public string DeliverySCAC { get; set; }
        public string MODE { get; set; }
        public string TrailerID { get; set; }
        public string TransportID { get; set; }
        public string CustomerName { get; set; }
        public string PO_Number { get; set; }
        public string SupplierCode { get; set; }
        public string Sello1 { get; set; }
        public string Sello2 { get; set; }
        public string Sello3 { get; set; }
        public string Sello4 { get; set; }
        public string CustomerInfo { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? DiaOrden { get; set; }

        public bool? AddedInMPS { get; set; }
        public string ReferenceOrder { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? ReferenceDate { get; set; }

        public bool? Recurrence { get; set; }
        public int? RecurrencyPeriodID { get; set; }
        public string HoraOrden { get; set; }
        public string NombreTecnico { get; set; }
        // FinanSaaS POS
        public string TerminalID { get; set; }
        
        public List<OrderDetail> Details { get; set; }
        
        public List<PaymentMethodDetail> PaymentDetails { get; set; }
    }

    public class OrderDetail
    {
        public string CompanyID { get; set; }
        public string DivisionID { get; set; }
        public string DepartmentID { get; set; }
        public string OrderNumber { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal OrderLineNumber { get; set; }

        public string ItemID { get; set; }
        public string ItemUPCCode { get; set; }
        public string WarehouseID { get; set; }
        public string WarehouseBinID { get; set; }
        public string SerialNumber { get; set; }
        public string Description { get; set; }
        public double? OrderQty { get; set; }
        public bool? BackOrdered { get; set; }
        public double? BackOrderQyyty { get; set; }
        public string ItemUOM { get; set; }
        public double? ItemWeight { get; set; }
        public double? DiscountPerc { get; set; }
        public bool? Taxable { get; set; }
        public string CurrencyID { get; set; }
        public double? CurrencyExchangeRate { get; set; }
        public decimal? ItemCost { get; set; }
        public decimal? ItemUnitPrice { get; set; }
        public string TaxGroupID { get; set; }
        public decimal? TaxAmount { get; set; }
        public double? TaxPercent { get; set; }
        public decimal? SubTotal { get; set; }
        public decimal? Total { get; set; }
        public double? TotalWeight { get; set; }
        public string GLSalesAccount { get; set; }
        public string ProjectID { get; set; }
        public string TrackingNumber { get; set; }
        public string WarehouseBinZone { get; set; }
        public string PalletLevel { get; set; }
        public string CartonLevel { get; set; }
        public string PackLevelA { get; set; }
        public string PackLevelB { get; set; }
        public string PackLevelC { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? ScheduledStartDate { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? ScheduledEndDate { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? ServiceStartDate { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? ServiceEndDate { get; set; }

        public string PerformedBy { get; set; }
        public string DetailMemo1 { get; set; }
        public string DetailMemo2 { get; set; }
        public string DetailMemo3 { get; set; }
        public string DetailMemo4 { get; set; }
        public string DetailMemo5 { get; set; }
        public string LockedBy { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? LockTS { get; set; }

        public string SerieTelefono { get; set; }
        public decimal? DriverCommission { get; set; }
        public decimal? Gasoline { get; set; }
        public string DriverID { get; set; }
        public string GasolineLT { get; set; }
        public string CantidadBultos { get; set; }
        public bool? AddedInMPS { get; set; }
        public double? BoxesQty { get; set; }
    }

    public class PaymentMethodDetail
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int PaymentMethodId { get; set; }
        public string PaymentMethodsFinanSaaSID { get; set; }
        public string CurrencyId { get; set; }

        public string Info { get; set; }
        public double Amount { get; set; } = 0;
        public double AmountConverted { get; set; } = 0;
        public string AmountFormated { get; set; }
    }
}
