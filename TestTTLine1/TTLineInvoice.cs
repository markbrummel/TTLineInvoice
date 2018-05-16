using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TestTTLine1
{
    public class TTLineInvoice
    {
        //        public TT_Invoice GetInvoiceFromStream(MemoryStream mem)
        //        {
        //            var serializer = new XmlSerializer(typeof(TT_Invoice));
        //            var test = (TT_Invoice)serializer.Deserialize(mem);
        //            return (test);
        //
        //        }
        //    }
        public TT_Invoice GetInvoiceFromStream(FileStream xml)
        {
            MemoryStream mem = new MemoryStream();
            mem.SetLength(xml.Length);
            xml.Read(mem.GetBuffer(), 0, (int)xml.Length);
            var serializer = new XmlSerializer(typeof(TT_Invoice));
            var test = (TT_Invoice)serializer.Deserialize(mem);
            return (test);

        }
    }
        // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
        /// <remarks/>
        [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class TT_Invoice
    {

        private TT_InvoiceHeader headerField;

        private TT_InvoiceSailing[] sailingField;

        private TT_InvoiceTotals totalsField;

        /// <remarks/>
        public TT_InvoiceHeader Header
        {
            get
            {
                return this.headerField;
            }
            set
            {
                this.headerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Sailing")]
        public TT_InvoiceSailing[] Sailing
        {
            get
            {
                return this.sailingField;
            }
            set
            {
                this.sailingField = value;
            }
        }

        /// <remarks/>
        public TT_InvoiceTotals Totals
        {
            get
            {
                return this.totalsField;
            }
            set
            {
                this.totalsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class TT_InvoiceHeader
    {

        private uint invoiceNoField;

        private System.DateTime invoiceDateField;

        private string invoiceTypeField;

        private string customerName1Field;

        private string customerAddress1Field;

        private string customerCountryField;

        private string customerPostcodeField;

        private string customerTownField;

        private uint customerNumberField;

        private string tTOfficeNameField;

        private string tTOfficeAddressField;

        private string tTOfficeCountryField;

        private ushort tTOfficePostcodeField;

        private string tTOfficeTownField;

        private string tTVatNoField;

        private string tTTelephoneField;

        private string tTFaxField;

        private byte positionsInInvoiceField;

        private byte sailingsInInvoiceField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint InvoiceNo
        {
            get
            {
                return this.invoiceNoField;
            }
            set
            {
                this.invoiceNoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
        public System.DateTime InvoiceDate
        {
            get
            {
                return this.invoiceDateField;
            }
            set
            {
                this.invoiceDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string InvoiceType
        {
            get
            {
                return this.invoiceTypeField;
            }
            set
            {
                this.invoiceTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CustomerName1
        {
            get
            {
                return this.customerName1Field;
            }
            set
            {
                this.customerName1Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CustomerAddress1
        {
            get
            {
                return this.customerAddress1Field;
            }
            set
            {
                this.customerAddress1Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CustomerCountry
        {
            get
            {
                return this.customerCountryField;
            }
            set
            {
                this.customerCountryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CustomerPostcode
        {
            get
            {
                return this.customerPostcodeField;
            }
            set
            {
                this.customerPostcodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CustomerTown
        {
            get
            {
                return this.customerTownField;
            }
            set
            {
                this.customerTownField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint CustomerNumber
        {
            get
            {
                return this.customerNumberField;
            }
            set
            {
                this.customerNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TTOfficeName
        {
            get
            {
                return this.tTOfficeNameField;
            }
            set
            {
                this.tTOfficeNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TTOfficeAddress
        {
            get
            {
                return this.tTOfficeAddressField;
            }
            set
            {
                this.tTOfficeAddressField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TTOfficeCountry
        {
            get
            {
                return this.tTOfficeCountryField;
            }
            set
            {
                this.tTOfficeCountryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort TTOfficePostcode
        {
            get
            {
                return this.tTOfficePostcodeField;
            }
            set
            {
                this.tTOfficePostcodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TTOfficeTown
        {
            get
            {
                return this.tTOfficeTownField;
            }
            set
            {
                this.tTOfficeTownField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TTVatNo
        {
            get
            {
                return this.tTVatNoField;
            }
            set
            {
                this.tTVatNoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TTTelephone
        {
            get
            {
                return this.tTTelephoneField;
            }
            set
            {
                this.tTTelephoneField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TTFax
        {
            get
            {
                return this.tTFaxField;
            }
            set
            {
                this.tTFaxField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte PositionsInInvoice
        {
            get
            {
                return this.positionsInInvoiceField;
            }
            set
            {
                this.positionsInInvoiceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte SailingsInInvoice
        {
            get
            {
                return this.sailingsInInvoiceField;
            }
            set
            {
                this.sailingsInInvoiceField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class TT_InvoiceSailing
    {

        private TT_InvoiceSailingPosition[] positionField;

        private string[] textField;

        private string departportField;

        private string arrivlportField;

        private System.DateTime saildateField;

        private System.DateTime sailtimeField;

        private string shipcodeField;

        private string shipnameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Position")]
        public TT_InvoiceSailingPosition[] Position
        {
            get
            {
                return this.positionField;
            }
            set
            {
                this.positionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string[] Text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Departport
        {
            get
            {
                return this.departportField;
            }
            set
            {
                this.departportField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Arrivlport
        {
            get
            {
                return this.arrivlportField;
            }
            set
            {
                this.arrivlportField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
        public System.DateTime Saildate
        {
            get
            {
                return this.saildateField;
            }
            set
            {
                this.saildateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "time")]
        public System.DateTime Sailtime
        {
            get
            {
                return this.sailtimeField;
            }
            set
            {
                this.sailtimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Shipcode
        {
            get
            {
                return this.shipcodeField;
            }
            set
            {
                this.shipcodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Shipname
        {
            get
            {
                return this.shipnameField;
            }
            set
            {
                this.shipnameField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class TT_InvoiceSailingPosition
    {

        private TT_InvoiceSailingPositionCharges[] chargesField;

        private TT_InvoiceSailingPositionSubtotal subtotalField;

        private byte positionNoField;

        private string tTBookingRefField;

        private string customerRefField;

        private string registrationNo1Field;

        private string registrationNo2Field;

        private string shipperField;

        private ushort weightField;

        private string unitLengthField;

        private string netSignField;

        private string netAmountField;

        private string rateDescriptionField;

        private byte chargesInPositionField;

        private bool chargesInPositionFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Charges")]
        public TT_InvoiceSailingPositionCharges[] Charges
        {
            get
            {
                return this.chargesField;
            }
            set
            {
                this.chargesField = value;
            }
        }

        /// <remarks/>
        public TT_InvoiceSailingPositionSubtotal Subtotal
        {
            get
            {
                return this.subtotalField;
            }
            set
            {
                this.subtotalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte PositionNo
        {
            get
            {
                return this.positionNoField;
            }
            set
            {
                this.positionNoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TTBookingRef
        {
            get
            {
                return this.tTBookingRefField;
            }
            set
            {
                this.tTBookingRefField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CustomerRef
        {
            get
            {
                return this.customerRefField;
            }
            set
            {
                this.customerRefField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RegistrationNo1
        {
            get
            {
                return this.registrationNo1Field;
            }
            set
            {
                this.registrationNo1Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RegistrationNo2
        {
            get
            {
                return this.registrationNo2Field;
            }
            set
            {
                this.registrationNo2Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Shipper
        {
            get
            {
                return this.shipperField;
            }
            set
            {
                this.shipperField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort Weight
        {
            get
            {
                return this.weightField;
            }
            set
            {
                this.weightField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string UnitLength
        {
            get
            {
                return this.unitLengthField;
            }
            set
            {
                this.unitLengthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NetSign
        {
            get
            {
                return this.netSignField;
            }
            set
            {
                this.netSignField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NetAmount
        {
            get
            {
                return this.netAmountField;
            }
            set
            {
                this.netAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RateDescription
        {
            get
            {
                return this.rateDescriptionField;
            }
            set
            {
                this.rateDescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte ChargesInPosition
        {
            get
            {
                return this.chargesInPositionField;
            }
            set
            {
                this.chargesInPositionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ChargesInPositionSpecified
        {
            get
            {
                return this.chargesInPositionFieldSpecified;
            }
            set
            {
                this.chargesInPositionFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class TT_InvoiceSailingPositionCharges
    {

        private byte chargeNoField;

        private string chargeDescriptionField;

        private string chargeSignField;

        private string chargeAmountField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte ChargeNo
        {
            get
            {
                return this.chargeNoField;
            }
            set
            {
                this.chargeNoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ChargeDescription
        {
            get
            {
                return this.chargeDescriptionField;
            }
            set
            {
                this.chargeDescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ChargeSign
        {
            get
            {
                return this.chargeSignField;
            }
            set
            {
                this.chargeSignField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ChargeAmount
        {
            get
            {
                return this.chargeAmountField;
            }
            set
            {
                this.chargeAmountField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class TT_InvoiceSailingPositionSubtotal
    {

        private string subtotalSignField;

        private string subtotalAmountField;

        private string subtotalAmount2Field;

        private string subtotalCurrencyField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SubtotalSign
        {
            get
            {
                return this.subtotalSignField;
            }
            set
            {
                this.subtotalSignField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SubtotalAmount
        {
            get
            {
                return this.subtotalAmountField;
            }
            set
            {
                this.subtotalAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SubtotalAmount2
        {
            get
            {
                return this.subtotalAmount2Field;
            }
            set
            {
                this.subtotalAmount2Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SubtotalCurrency
        {
            get
            {
                return this.subtotalCurrencyField;
            }
            set
            {
                this.subtotalCurrencyField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class TT_InvoiceTotals
    {

        private string currencyField;

        private string exchangeRateField;

        private string netAmountSignField;

        private string netAmountField;

        private string vatPercentField;

        private string vatSignField;

        private string vatAmountField;

        private string vatAmount2Field;

        private string grossSignField;

        private string grossAmountField;

        private string grossAmount2Field;

        private byte termsOfPaymentField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Currency
        {
            get
            {
                return this.currencyField;
            }
            set
            {
                this.currencyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ExchangeRate
        {
            get
            {
                return this.exchangeRateField;
            }
            set
            {
                this.exchangeRateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NetAmountSign
        {
            get
            {
                return this.netAmountSignField;
            }
            set
            {
                this.netAmountSignField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string NetAmount
        {
            get
            {
                return this.netAmountField;
            }
            set
            {
                this.netAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string VatPercent
        {
            get
            {
                return this.vatPercentField;
            }
            set
            {
                this.vatPercentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string VatSign
        {
            get
            {
                return this.vatSignField;
            }
            set
            {
                this.vatSignField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string VatAmount
        {
            get
            {
                return this.vatAmountField;
            }
            set
            {
                this.vatAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string VatAmount2
        {
            get
            {
                return this.vatAmount2Field;
            }
            set
            {
                this.vatAmount2Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string GrossSign
        {
            get
            {
                return this.grossSignField;
            }
            set
            {
                this.grossSignField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string GrossAmount
        {
            get
            {
                return this.grossAmountField;
            }
            set
            {
                this.grossAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string GrossAmount2
        {
            get
            {
                return this.grossAmount2Field;
            }
            set
            {
                this.grossAmount2Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte TermsOfPayment
        {
            get
            {
                return this.termsOfPaymentField;
            }
            set
            {
                this.termsOfPaymentField = value;
            }
        }
    }


}
