using System.Text;
using UploadPatronExcelAOF.Entity;

namespace UploadPatronExcelAOF.Z303
{
    internal class z305
    {
        public string tab5(PatronEntity patronEntity, string block, string borStatus, string subLibrary, string holdOnShelf, string bookingPermission, string bookingIgnoreHour, string rushCatRequest)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("<z305>");
            stringBuilder.Append("<record-action>A</record-action>");
            stringBuilder.Append("<z305-id>" + patronEntity.pationID + "</z305-id>");
            stringBuilder.Append("<z305-sub-library>" + subLibrary + "</z305-sub-library>");
            stringBuilder.Append("<z305-open-date>" + patronEntity.Day + "</z305-open-date>");
            stringBuilder.Append("<z305-update-date>" + patronEntity.Day + "</z305-update-date>");
            //stringBuilder.Append("<z305-bor-type>" + bor_type(patronEntity.makh) + "</z305-bor-type>");
            stringBuilder.Append("<z305-bor-status>"+ borStatus + "</z305-bor-status>");
            stringBuilder.Append("<z305-registration-date>" + patronEntity.Day + "</z305-registration-date>");
            stringBuilder.Append("<z305-expiry-date>" + patronEntity.NgayHetHan + "</z305-expiry-date>");
            stringBuilder.Append("<z305-note></z305-note>");
            stringBuilder.Append("<z305-loan-permission>N</z305-loan-permission>");
            stringBuilder.Append("<z305-photo-permission>N</z305-photo-permission>");
            stringBuilder.Append("<z305-over-permission>N</z305-over-permission>");
            stringBuilder.Append("<z305-multi-hold>N</z305-multi-hold>");
            stringBuilder.Append("<z305-loan-check>N</z305-loan-check>");
            stringBuilder.Append("<z305-hold-permission>N</z305-hold-permission>");
            stringBuilder.Append("<z305-renew-permission>N</z305-renew-permission>");
            stringBuilder.Append("<z305-rr-permission>N</z305-rr-permission>");
            stringBuilder.Append("<z305-ignore-late-return>N</z305-ignore-late-return>");
            stringBuilder.Append("<z305-last-activity-date>00000000</z305-last-activity-date>");
            stringBuilder.Append("<z305-photo-charge>F</z305-photo-charge>");
            stringBuilder.Append("<z305-no-loan>0000</z305-no-loan>");
            stringBuilder.Append("<z305-no-hold>0000</z305-no-hold>");
            stringBuilder.Append("<z305-no-photo>0000</z305-no-photo>");
            stringBuilder.Append("<z305-no-cash>0000</z305-no-cash>");
            stringBuilder.Append("<z305-cash-limit>0.00</z305-cash-limit>");
            stringBuilder.Append("<z305-credit-debit></z305-credit-debit>");
            stringBuilder.Append("<z305-sum>0.00</z305-sum>");
            stringBuilder.Append("<z305-delinq-1>" + block + "</z305-delinq-1>");
            stringBuilder.Append("<z305-delinq-n-1></z305-delinq-n-1>");
            stringBuilder.Append("<z305-delinq-1-update-date></z305-delinq-1-update-date>");
            stringBuilder.Append("<z305-delinq-1-cat-name>MASTER</z305-delinq-1-cat-name>");
            stringBuilder.Append("<z305-delinq-2>00</z305-delinq-2>");
            stringBuilder.Append("<z305-delinq-n-2></z305-delinq-n-2>");
            stringBuilder.Append("<z305-delinq-2-update-date>" + patronEntity.Day + "</z305-delinq-2-update-date>");
            stringBuilder.Append("<z305-delinq-2-cat-name>MASTER</z305-delinq-2-cat-name>");
            stringBuilder.Append("<z305-delinq-3>00</z305-delinq-3>");
            stringBuilder.Append("<z305-delinq-n-3></z305-delinq-n-3>");
            stringBuilder.Append("<z305-delinq-3-update-date>" + patronEntity.Day + "</z305-delinq-3-update-date>");
            stringBuilder.Append("<z305-delinq-3-cat-name>MASTER</z305-delinq-3-cat-name>");
            stringBuilder.Append("<z305-field-1>" + patronEntity.khoaHoc + "</z305-field-1>");
            stringBuilder.Append("<z305-field-2>" + patronEntity.lopHoc + "</z305-field-2>");
            stringBuilder.Append("<z305-field-3>" + patronEntity.Khoa + "</z305-field-3>");
            stringBuilder.Append("<z305-hold-on-shelf>"+ holdOnShelf + "</z305-hold-on-shelf>");
            stringBuilder.Append("<z305-end-block-date>00000000</z305-end-block-date>");
            stringBuilder.Append("<z305-booking-permission>" + bookingPermission + "</z305-booking-permission>");
            stringBuilder.Append("<z305-booking-ignore-hours>" + bookingIgnoreHour + "N</z305-booking-ignore-hours>");
            stringBuilder.Append("<z305-rush-cat-request>" + rushCatRequest + "</z305-rush-cat-request>");
            stringBuilder.Append("</z305>");


            //stringBuilder.Append("<z305>");
            //stringBuilder.Append("<record-action>A</record-action>");
            //stringBuilder.Append("<z305-id>" + patronEntity.pationID + "</z305-id>");
            //stringBuilder.Append("<z305-sub-library>LDC50</z305-sub-library>");
            //stringBuilder.Append("<z305-open-date>" + patronEntity.Day + "</z305-open-date>");
            //stringBuilder.Append("<z305-update-date>" + patronEntity.Day + "</z305-update-date>");
            ////stringBuilder.Append("<z305-bor-type>" + bor_type(patronEntity.makh) + "</z305-bor-type>");
            //stringBuilder.Append("<z305-bor-status>01</z305-bor-status>");
            //stringBuilder.Append("<z305-registration-date>" + patronEntity.Day + "</z305-registration-date>");
            //stringBuilder.Append("<z305-expiry-date>" + patronEntity.Day4 + "</z305-expiry-date>");
            //stringBuilder.Append("<z305-note></z305-note>");
            //stringBuilder.Append("<z305-loan-permission>N</z305-loan-permission>");
            //stringBuilder.Append("<z305-photo-permission>N</z305-photo-permission>");
            //stringBuilder.Append("<z305-over-permission>N</z305-over-permission>");
            //stringBuilder.Append("<z305-multi-hold>N</z305-multi-hold>");
            //stringBuilder.Append("<z305-loan-check>N</z305-loan-check>");
            //stringBuilder.Append("<z305-hold-permission>N</z305-hold-permission>");
            //stringBuilder.Append("<z305-renew-permission>N</z305-renew-permission>");
            //stringBuilder.Append("<z305-rr-permission>N</z305-rr-permission>");
            //stringBuilder.Append("<z305-ignore-late-return>N</z305-ignore-late-return>");
            //stringBuilder.Append("<z305-last-activity-date>00000000</z305-last-activity-date>");
            //stringBuilder.Append("<z305-photo-charge>F</z305-photo-charge>");
            //stringBuilder.Append("<z305-no-loan>0000</z305-no-loan>");
            //stringBuilder.Append("<z305-no-hold>0000</z305-no-hold>");
            //stringBuilder.Append("<z305-no-photo>0000</z305-no-photo>");
            //stringBuilder.Append("<z305-no-cash>0000</z305-no-cash>");
            //stringBuilder.Append("<z305-cash-limit>0.00</z305-cash-limit>");
            //stringBuilder.Append("<z305-credit-debit></z305-credit-debit>");
            //stringBuilder.Append("<z305-sum>0.00</z305-sum>");
            //stringBuilder.Append("<z305-delinq-1>00</z305-delinq-1>");
            //stringBuilder.Append("<z305-delinq-n-1></z305-delinq-n-1>");
            //stringBuilder.Append("<z305-delinq-1-update-date></z305-delinq-1-update-date>");
            //stringBuilder.Append("<z305-delinq-1-cat-name>MASTER</z305-delinq-1-cat-name>");
            //stringBuilder.Append("<z305-delinq-2>00</z305-delinq-2>");
            //stringBuilder.Append("<z305-delinq-n-2></z305-delinq-n-2>");
            //stringBuilder.Append("<z305-delinq-2-update-date>" + patronEntity.Day + "</z305-delinq-2-update-date>");
            //stringBuilder.Append("<z305-delinq-2-cat-name>MASTER</z305-delinq-2-cat-name>");
            //stringBuilder.Append("<z305-delinq-3>00</z305-delinq-3>");
            //stringBuilder.Append("<z305-delinq-n-3></z305-delinq-n-3>");
            //stringBuilder.Append("<z305-delinq-3-update-date>" + patronEntity.Day + "</z305-delinq-3-update-date>");
            //stringBuilder.Append("<z305-delinq-3-cat-name>MASTER</z305-delinq-3-cat-name>");
            //stringBuilder.Append("<z305-field-1>" + patronEntity.khoaHoc + "</z305-field-1>");
            //stringBuilder.Append("<z305-field-2>" + patronEntity.lopHoc + "</z305-field-2>");
            //stringBuilder.Append("<z305-field-3></z305-field-3>");
            //stringBuilder.Append("<z305-hold-on-shelf>N</z305-hold-on-shelf>");
            //stringBuilder.Append("<z305-end-block-date>00000000</z305-end-block-date>");
            //stringBuilder.Append("<z305-booking-permission>Y</z305-booking-permission>");
            //stringBuilder.Append("<z305-booking-ignore-hours>N</z305-booking-ignore-hours>");
            //stringBuilder.Append("<z305-rush-cat-request>Y</z305-rush-cat-request>");
            //stringBuilder.Append("</z305>");

            //stringBuilder.Append("<z305>");
            //stringBuilder.Append("<record-action>A</record-action>");
            //stringBuilder.Append("<z305-id>" + patronEntity.pationID + "</z305-id>");
            //stringBuilder.Append("<z305-sub-library>ALEPH</z305-sub-library>");
            //stringBuilder.Append("<z305-open-date>" + patronEntity.Day + "</z305-open-date>");
            //stringBuilder.Append("<z305-update-date>" + patronEntity.Day + "</z305-update-date>");
            ////stringBuilder.Append("<z305-bor-type>" + bor_type(patronEntity.makh) + "</z305-bor-type>");
            //stringBuilder.Append("<z305-bor-status>01</z305-bor-status>");
            //stringBuilder.Append("<z305-registration-date>" + patronEntity.Day + "</z305-registration-date>");
            //stringBuilder.Append("<z305-expiry-date>" + patronEntity.Day4 + "</z305-expiry-date>");
            //stringBuilder.Append("<z305-note></z305-note>");
            //stringBuilder.Append("<z305-loan-permission>N</z305-loan-permission>");
            //stringBuilder.Append("<z305-photo-permission>N</z305-photo-permission>");
            //stringBuilder.Append("<z305-over-permission>N</z305-over-permission>");
            //stringBuilder.Append("<z305-multi-hold>N</z305-multi-hold>");
            //stringBuilder.Append("<z305-loan-check>N</z305-loan-check>");
            //stringBuilder.Append("<z305-hold-permission>N</z305-hold-permission>");
            //stringBuilder.Append("<z305-renew-permission>N</z305-renew-permission>");
            //stringBuilder.Append("<z305-rr-permission>N</z305-rr-permission>");
            //stringBuilder.Append("<z305-ignore-late-return>N</z305-ignore-late-return>");
            //stringBuilder.Append("<z305-last-activity-date>00000000</z305-last-activity-date>");
            //stringBuilder.Append("<z305-photo-charge>F</z305-photo-charge>");
            //stringBuilder.Append("<z305-no-loan>0000</z305-no-loan>");
            //stringBuilder.Append("<z305-no-hold>0000</z305-no-hold>");
            //stringBuilder.Append("<z305-no-photo>0000</z305-no-photo>");
            //stringBuilder.Append("<z305-no-cash>0000</z305-no-cash>");
            //stringBuilder.Append("<z305-cash-limit>0.00</z305-cash-limit>");
            //stringBuilder.Append("<z305-credit-debit></z305-credit-debit>");
            //stringBuilder.Append("<z305-sum>0.00</z305-sum>");
            //stringBuilder.Append("<z305-delinq-1>00</z305-delinq-1>");
            //stringBuilder.Append("<z305-delinq-n-1></z305-delinq-n-1>");
            //stringBuilder.Append("<z305-delinq-1-update-date></z305-delinq-1-update-date>");
            //stringBuilder.Append("<z305-delinq-1-cat-name>MASTER</z305-delinq-1-cat-name>");
            //stringBuilder.Append("<z305-delinq-2>00</z305-delinq-2>");
            //stringBuilder.Append("<z305-delinq-n-2></z305-delinq-n-2>");
            //stringBuilder.Append("<z305-delinq-2-update-date>" + patronEntity.Day + "</z305-delinq-2-update-date>");
            //stringBuilder.Append("<z305-delinq-2-cat-name>MASTER</z305-delinq-2-cat-name>");
            //stringBuilder.Append("<z305-delinq-3>00</z305-delinq-3>");
            //stringBuilder.Append("<z305-delinq-n-3></z305-delinq-n-3>");
            //stringBuilder.Append("<z305-delinq-3-update-date>" + patronEntity.Day + "</z305-delinq-3-update-date>");
            //stringBuilder.Append("<z305-delinq-3-cat-name>MASTER</z305-delinq-3-cat-name>");
            //stringBuilder.Append("<z305-field-1>" + patronEntity.khoaHoc + "</z305-field-1>");
            //stringBuilder.Append("<z305-field-2>" + patronEntity.lopHoc + "</z305-field-2>");
            //stringBuilder.Append("<z305-field-3></z305-field-3>");
            //stringBuilder.Append("<z305-hold-on-shelf>N</z305-hold-on-shelf>");
            //stringBuilder.Append("<z305-end-block-date>00000000</z305-end-block-date>");
            //stringBuilder.Append("<z305-booking-permission>Y</z305-booking-permission>");
            //stringBuilder.Append("<z305-booking-ignore-hours>N</z305-booking-ignore-hours>");
            //stringBuilder.Append("<z305-rush-cat-request>Y</z305-rush-cat-request>");
            //stringBuilder.Append("</z305>");
            return stringBuilder.ToString();
        }

        public string bor_type(string str)
        {
            switch (str.ToUpper().Trim())
            {
                case "CD":
                    return "AJ";
                case "CN":
                    return "AG";
                case "CP":
                    return "AZ";
                case "KE":
                    return "AC";
                case "KT":
                    return "AV";
                case "MT":
                    return "AN";
                case "NH":
                    return "AM";
                case "SN":
                    return "BW";
                case "TY":
                    return "BR";
                case "TH":
                    return "AL";
                default:
                    return "";
            }
        }
    }
}
