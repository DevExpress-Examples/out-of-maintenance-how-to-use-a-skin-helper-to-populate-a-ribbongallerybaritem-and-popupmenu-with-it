using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Helpers;
using DevExpress.XtraBars.Localization;

namespace HowToUseBarSkinHelper {
    public partial class Form1 : RibbonForm {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            BarLocalizer.Active = new MyBarLocalizer();

            SkinHelper.InitSkinGallery(ribbonGalleryBarItem1, true);
            SkinHelper.InitSkinPopupMenu(popupMenu1);
        }
    }

    // Custom localizer that changes skin captions 
    public class MyBarLocalizer : BarLocalizer {
        public override string GetLocalizedString(BarString id) {
            if (id == BarString.SkinCaptions) {
                //Default value for BarString.SkinCaptions:
                //"|DevExpress Style|Caramel|Money Twins|DevExpress Dark Style|iMaginary|Lilian|Black|Blue|Office 2010 Blue|Office 2010 Black|Office 2010 Silver|Office 2007 Blue|Office 2007 Black|Office 2007 Silver|Office 2007 Green|Office 2007 Pink|Seven|Seven Classic|Darkroom|McSkin|Sharp|Sharp Plus|Foggy|Dark Side|Xmas (Blue)|Springtime|Summer|Pumpkin|Valentine|Stardust|Coffee|Glass Oceans|High Contrast|Liquid Sky|London Liquid Sky|The Asphalt World|Blueprint|"
                string defaultSkinCaptions = base.GetLocalizedString(id);
                string newSkinCaptions = defaultSkinCaptions.Replace("|DevExpress Style|", "|My Favorite Skin|");
                return newSkinCaptions;
            }
            return base.GetLocalizedString(id);
        }

        
    }
}