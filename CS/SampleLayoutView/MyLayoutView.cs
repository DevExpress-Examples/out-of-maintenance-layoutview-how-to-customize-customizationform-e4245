using System;
using System.Linq;
using DevExpress.XtraGrid;
using System.Collections.Generic;
using DevExpress.XtraGrid.Views.Layout;
using DevExpress.XtraGrid.Views.Layout.Customization;
using DevExpress.XtraGrid.Registrator;
using DevExpress.XtraGrid.Views.Base;
using System.Drawing;
using DevExpress.XtraTab;
using System.ComponentModel;
using DevExpress.Utils.Serializing;
using DevExpress.XtraEditors;
using System.Windows.Forms;
using DevExpress.Utils.Frames;


namespace SampleLayoutView
{
    public class MyGridControl : GridControl
    {
        protected override void RegisterAvailableViewsCore(InfoCollection collection)
        {
            base.RegisterAvailableViewsCore(collection);
            collection.Add(new MyLayoutViewInfoRegistrator());
        }
    }

    public class MyLayoutViewInfoRegistrator : GridInfoRegistrator
    {
        public override string ViewName { get { return "MyLayoutView"; } }
        public override BaseView CreateView(GridControl grid)
        {
            return new MyLayoutView(grid as GridControl);
        }
    }

    public class MyLayoutView : LayoutView
    {
        public MyLayoutView() : this(null) {}
        public MyLayoutView(GridControl grid) : base(grid) {}


        public new LayoutViewCustomizationForm CustomizationForm {
            get { return base.CustomizationForm; }
        }

        protected override void ShowCustomizationFormCore(bool dialog)
        {
            RaiseEvent_ShowCustomization(this, null);
            OptionsCustomizationAppearance.SetCustomizationFormAppearance(CustomizationForm);
            if (dialog) CustomizationForm.ShowDialog();
            else CustomizationForm.Show();
        }

        [Browsable(true)]
        public class OptionsCustomizationFormAppearance
        {
            [DefaultValue("LayoutView Customization")]
            public string Text { get; set; }
            [DefaultValue("Show &More Cards")]
            public string btnShowMoreCardsText { get; set; }
            [DefaultValue("&Ok")]
            public string btnOkText { get; set; }
            [DefaultValue("&Cancel")]
            public string btnCancelText { get; set; }
            [DefaultValue("&Apply")]
            public string btnApplyText { get; set; }
            [DefaultValue(typeof(Point), "10, 9")]
            public Point btnShowMoreCardsLocation { get; set; }
            [DefaultValue(typeof(Point), "424, 9")]
            public Point btnOkLocation { get; set; }
            [DefaultValue(typeof(Point), "512, 9")]
            public Point btnCancelLocation { get; set; }
            [DefaultValue(typeof(Point), "600, 9")]
            public Point btnApplyLocation { get; set; }
            [DefaultValue("Customize the card layout using drag-and-drop and customization menu, and preview data in the View Layout page.")]
            public string HintPanelText { get; set; }
            [DefaultValue(true)]
            public bool HintPanelVisible { get; set; }
            [DefaultValue(true)]
            public bool TabPageEnabled { get; set; }
            [DefaultValue(true)]
            public bool TabControlVisible { get; set; }
            [DefaultValue(LayoutViewMode.SingleRecord), XtraSerializableProperty()]
            public LayoutViewMode PreviewLayoutViewMode { get; set; }

            public OptionsCustomizationFormAppearance()
            {
                RestoreDefaultAppearance();
            }

            public void RestoreDefaultAppearance()
            {
                Text = "LayoutView Customization";
                btnShowMoreCardsText = "Show &More Cards";
                btnOkText = "&Ok";
                btnCancelText = "&Cancel";
                btnApplyText = "&Apply";
                btnShowMoreCardsLocation = new Point(10, 9);
                btnOkLocation = new Point(424, 9);
                btnCancelLocation = new Point(512, 9);
                btnApplyLocation = new Point(600, 9);
                HintPanelText = "Customize the card layout using drag-and-drop and customization menu, and preview data in the View Layout page.";
                HintPanelVisible = true;
                TabPageEnabled = true;
                TabControlVisible = true;
                PreviewLayoutViewMode = LayoutViewMode.SingleRecord;
            }

            public void SetCustomizationFormAppearance(LayoutViewCustomizationForm form)
            {
                form.Text = Text;
                SetProperty(form, "sbPreview", btnShowMoreCardsText, btnShowMoreCardsLocation);
                SetProperty(form, "btnApply", btnApplyText, btnApplyLocation);
                SetProperty(form, "btnOk", btnOkText, btnOkLocation);
                SetProperty(form, "btnCancel", btnCancelText, btnCancelLocation);
                SetProperty(form, new NotePanelEx(), HintPanelText, HintPanelVisible);
                SetProperty(form, new XtraTabPage(), TabPageEnabled);
                SetProperty(form, new XtraTabControl(), TabControlVisible);
                SetProperty(form, new GridControl(), PreviewLayoutViewMode);
            }

            void SetProperty(LayoutViewCustomizationForm form, string name, string value, Point location)
            {
                Control[] controls = form.Controls.Find(name, true);
                if (controls.Length > 0)
                {
                    Control btn = controls[0];
                    if (btn != null){
                        btn.Text = value;
                        btn.Location = location;
                    }
                }
            }
            void SetProperty(LayoutViewCustomizationForm form, NotePanelEx obj, string text, bool visibility)
            {
                var panel = GetAll(form.Controls[0], typeof(NotePanelEx)).ElementAt(0);
                if (panel != null)
                {
                    panel.Text = text;
                    panel.Visible = visibility;
                }
            }
            void SetProperty(LayoutViewCustomizationForm form, XtraTabPage obj, bool value)
            {
                var tab = GetAll(form.Controls[0], typeof(XtraTabPage)).ElementAt(0);
                if (tab != null)
                {
                    obj = tab as XtraTabPage;
                    obj.PageEnabled = value;
                }
            }
            void SetProperty(LayoutViewCustomizationForm form, XtraTabControl obj, bool value)
            {
                var tab = GetAll(form.Controls[0], typeof(XtraTabControl)).ElementAt(0);
                if (tab != null)
                {
                    obj = tab as XtraTabControl;
                    obj.Visible = value;
                }
            }
            void SetProperty(LayoutViewCustomizationForm form, GridControl obj, LayoutViewMode value)
            {
                var grid = GetAll(form.Controls[0], typeof(GridControl)).ElementAt(0);
                if (grid != null)
                {
                    obj = grid as GridControl;
                    (obj.MainView as LayoutView).OptionsView.ViewMode = PreviewLayoutViewMode;
                }
            }
            public IEnumerable<Control> GetAll(Control control, Type type)
            {
                var controls = control.Controls.Cast<Control>();

                return controls.SelectMany(ctrl => GetAll(ctrl, type))
                                          .Concat(controls)
                                          .Where(c => c.GetType() == type);
            }
        }
        OptionsCustomizationFormAppearance optionsCustomizationAppearance = new OptionsCustomizationFormAppearance();
        [Browsable(true)]
        [System.ComponentModel.TypeConverter(typeof(ExpandableObjectConverter))]
        public OptionsCustomizationFormAppearance OptionsCustomizationAppearance
        {
            get { return optionsCustomizationAppearance; }
            set { optionsCustomizationAppearance = value; }
        }
    }
}