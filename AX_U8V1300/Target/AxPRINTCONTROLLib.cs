//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: System.Reflection.AssemblyVersion("1.0.0.0")]
[assembly: System.Windows.Forms.AxHost.TypeLibraryTimeStamp("01/17/2018 14:14:20")]

namespace AxPRINTCONTROLLib {
    
    
    [System.Windows.Forms.AxHost.ClsidAttribute("{6dd3f42c-144c-4f50-9e0a-eb3d396d078a}")]
    [System.ComponentModel.DesignTimeVisibleAttribute(true)]
    [System.ComponentModel.DefaultEvent("SettingChanged")]
    public class AxPrintControl : System.Windows.Forms.AxHost {
        
        private PRINTCONTROLLib._DPrintControl ocx;
        
        private AxPrintControlEventMulticaster eventMulticaster;
        
        private System.Windows.Forms.AxHost.ConnectionPointCookie cookie;
        
        public AxPrintControl() : 
                base("6dd3f42c-144c-4f50-9e0a-eb3d396d078a") {
            this.SetAboutBoxDelegate(new AboutBoxDelegate(AboutBox));
        }
        
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        [System.Runtime.InteropServices.DispIdAttribute(1)]
        public virtual bool bDesignMode {
            get {
                if ((this.ocx == null)) {
                    throw new System.Windows.Forms.AxHost.InvalidActiveXStateException("bDesignMode", System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertyGet);
                }
                return this.ocx.bDesignMode;
            }
            set {
                if ((this.ocx == null)) {
                    throw new System.Windows.Forms.AxHost.InvalidActiveXStateException("bDesignMode", System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertySet);
                }
                this.ocx.bDesignMode = value;
            }
        }
        
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        [System.Runtime.InteropServices.DispIdAttribute(2)]
        public virtual bool EnableSave {
            get {
                if ((this.ocx == null)) {
                    throw new System.Windows.Forms.AxHost.InvalidActiveXStateException("EnableSave", System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertyGet);
                }
                return this.ocx.EnableSave;
            }
            set {
                if ((this.ocx == null)) {
                    throw new System.Windows.Forms.AxHost.InvalidActiveXStateException("EnableSave", System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertySet);
                }
                this.ocx.EnableSave = value;
            }
        }
        
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        [System.Runtime.InteropServices.DispIdAttribute(3)]
        public virtual bool ShowSegColon {
            get {
                if ((this.ocx == null)) {
                    throw new System.Windows.Forms.AxHost.InvalidActiveXStateException("ShowSegColon", System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertyGet);
                }
                return this.ocx.ShowSegColon;
            }
            set {
                if ((this.ocx == null)) {
                    throw new System.Windows.Forms.AxHost.InvalidActiveXStateException("ShowSegColon", System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertySet);
                }
                this.ocx.ShowSegColon = value;
            }
        }
        
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        [System.Runtime.InteropServices.DispIdAttribute(4)]
        public virtual bool ReserveSegTitlePos {
            get {
                if ((this.ocx == null)) {
                    throw new System.Windows.Forms.AxHost.InvalidActiveXStateException("ReserveSegTitlePos", System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertyGet);
                }
                return this.ocx.ReserveSegTitlePos;
            }
            set {
                if ((this.ocx == null)) {
                    throw new System.Windows.Forms.AxHost.InvalidActiveXStateException("ReserveSegTitlePos", System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertySet);
                }
                this.ocx.ReserveSegTitlePos = value;
            }
        }
        
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        [System.Runtime.InteropServices.DispIdAttribute(5)]
        public virtual bool ExportTableOnly {
            get {
                if ((this.ocx == null)) {
                    throw new System.Windows.Forms.AxHost.InvalidActiveXStateException("ExportTableOnly", System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertyGet);
                }
                return this.ocx.ExportTableOnly;
            }
            set {
                if ((this.ocx == null)) {
                    throw new System.Windows.Forms.AxHost.InvalidActiveXStateException("ExportTableOnly", System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertySet);
                }
                this.ocx.ExportTableOnly = value;
            }
        }
        
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        [System.Runtime.InteropServices.DispIdAttribute(20)]
        public virtual bool EnableExport {
            get {
                if ((this.ocx == null)) {
                    throw new System.Windows.Forms.AxHost.InvalidActiveXStateException("EnableExport", System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertyGet);
                }
                return this.ocx.EnableExport;
            }
            set {
                if ((this.ocx == null)) {
                    throw new System.Windows.Forms.AxHost.InvalidActiveXStateException("EnableExport", System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertySet);
                }
                this.ocx.EnableExport = value;
            }
        }
        
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        [System.Runtime.InteropServices.DispIdAttribute(21)]
        public virtual int PartialPrint {
            get {
                if ((this.ocx == null)) {
                    throw new System.Windows.Forms.AxHost.InvalidActiveXStateException("PartialPrint", System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertyGet);
                }
                return this.ocx.PartialPrint;
            }
            set {
                if ((this.ocx == null)) {
                    throw new System.Windows.Forms.AxHost.InvalidActiveXStateException("PartialPrint", System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertySet);
                }
                this.ocx.PartialPrint = value;
            }
        }
        
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        [System.Runtime.InteropServices.DispIdAttribute(24)]
        public virtual bool EnablePageHFSetting {
            get {
                if ((this.ocx == null)) {
                    throw new System.Windows.Forms.AxHost.InvalidActiveXStateException("EnablePageHFSetting", System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertyGet);
                }
                return this.ocx.EnablePageHFSetting;
            }
            set {
                if ((this.ocx == null)) {
                    throw new System.Windows.Forms.AxHost.InvalidActiveXStateException("EnablePageHFSetting", System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertySet);
                }
                this.ocx.EnablePageHFSetting = value;
            }
        }
        
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        [System.Runtime.InteropServices.DispIdAttribute(27)]
        public virtual int sFileType {
            get {
                if ((this.ocx == null)) {
                    throw new System.Windows.Forms.AxHost.InvalidActiveXStateException("sFileType", System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertyGet);
                }
                return this.ocx.sFileType;
            }
            set {
                if ((this.ocx == null)) {
                    throw new System.Windows.Forms.AxHost.InvalidActiveXStateException("sFileType", System.Windows.Forms.AxHost.ActiveXInvokeKind.PropertySet);
                }
                this.ocx.sFileType = value;
            }
        }
        
        public event _DPrintControlEvents_SettingChangedEventHandler SettingChanged;
        
        public event _DPrintControlEvents_BeginPrintingEventHandler BeginPrinting;
        
        public event _DPrintControlEvents_PrintingEventHandler Printing;
        
        public event System.EventHandler EndPrinting;
        
        public event _DPrintControlEvents_PressOKEventHandler PressOK;
        
        public virtual int SetDataStyleXML(object varDataXML, bool bDataIsFile, object varStyleXML, bool bStyleIsFile, object varModuleID) {
            if ((this.ocx == null)) {
                throw new System.Windows.Forms.AxHost.InvalidActiveXStateException("SetDataStyleXML", System.Windows.Forms.AxHost.ActiveXInvokeKind.MethodInvoke);
            }
            int returnValue = ((int)(this.ocx.SetDataStyleXML(varDataXML, bDataIsFile, varStyleXML, bStyleIsFile, varModuleID)));
            return returnValue;
        }
        
        public virtual int PageSetup() {
            if ((this.ocx == null)) {
                throw new System.Windows.Forms.AxHost.InvalidActiveXStateException("PageSetup", System.Windows.Forms.AxHost.ActiveXInvokeKind.MethodInvoke);
            }
            int returnValue = ((int)(this.ocx.PageSetup()));
            return returnValue;
        }
        
        public virtual int PrintPreview() {
            if ((this.ocx == null)) {
                throw new System.Windows.Forms.AxHost.InvalidActiveXStateException("PrintPreview", System.Windows.Forms.AxHost.ActiveXInvokeKind.MethodInvoke);
            }
            int returnValue = ((int)(this.ocx.PrintPreview()));
            return returnValue;
        }
        
        public virtual int DoPrint() {
            if ((this.ocx == null)) {
                throw new System.Windows.Forms.AxHost.InvalidActiveXStateException("DoPrint", System.Windows.Forms.AxHost.ActiveXInvokeKind.MethodInvoke);
            }
            int returnValue = ((int)(this.ocx.DoPrint()));
            return returnValue;
        }
        
        public virtual int SetOwner(int hwndOwner) {
            if ((this.ocx == null)) {
                throw new System.Windows.Forms.AxHost.InvalidActiveXStateException("SetOwner", System.Windows.Forms.AxHost.ActiveXInvokeKind.MethodInvoke);
            }
            int returnValue = ((int)(this.ocx.SetOwner(hwndOwner)));
            return returnValue;
        }
        
        public virtual int ExportToFile(int lJobId, object varColType, object varColSize, object varColName, object varTempDBPath) {
            if ((this.ocx == null)) {
                throw new System.Windows.Forms.AxHost.InvalidActiveXStateException("ExportToFile", System.Windows.Forms.AxHost.ActiveXInvokeKind.MethodInvoke);
            }
            int returnValue = ((int)(this.ocx.ExportToFile(lJobId, varColType, varColSize, varColName, varTempDBPath)));
            return returnValue;
        }
        
        public virtual int PrintEx(bool bShowPrintDlg) {
            if ((this.ocx == null)) {
                throw new System.Windows.Forms.AxHost.InvalidActiveXStateException("PrintEx", System.Windows.Forms.AxHost.ActiveXInvokeKind.MethodInvoke);
            }
            int returnValue = ((int)(this.ocx.PrintEx(bShowPrintDlg)));
            return returnValue;
        }
        
        public virtual int TriggerEvent(int lEventId) {
            if ((this.ocx == null)) {
                throw new System.Windows.Forms.AxHost.InvalidActiveXStateException("TriggerEvent", System.Windows.Forms.AxHost.ActiveXInvokeKind.MethodInvoke);
            }
            int returnValue = ((int)(this.ocx.TriggerEvent(lEventId)));
            return returnValue;
        }
        
        public virtual void GetErrorMessage(int lErrCode, ref object pvarErrMessage) {
            if ((this.ocx == null)) {
                throw new System.Windows.Forms.AxHost.InvalidActiveXStateException("GetErrorMessage", System.Windows.Forms.AxHost.ActiveXInvokeKind.MethodInvoke);
            }
            this.ocx.GetErrorMessage(lErrCode, ref pvarErrMessage);
        }
        
        public virtual void SetOB(object ob) {
            if ((this.ocx == null)) {
                throw new System.Windows.Forms.AxHost.InvalidActiveXStateException("SetOB", System.Windows.Forms.AxHost.ActiveXInvokeKind.MethodInvoke);
            }
            this.ocx.SetOB(ob);
        }
        
        public virtual int ExportToFileEx(int lJobId, object varColType, object varColSize, object varColName, object varTempDBPath) {
            if ((this.ocx == null)) {
                throw new System.Windows.Forms.AxHost.InvalidActiveXStateException("ExportToFileEx", System.Windows.Forms.AxHost.ActiveXInvokeKind.MethodInvoke);
            }
            int returnValue = ((int)(this.ocx.ExportToFileEx(lJobId, varColType, varColSize, varColName, varTempDBPath)));
            return returnValue;
        }
        
        public virtual int ExportToAttached(int lTypeId, int lJobId, object varColType, object varColSize, object varColName, object varTempDBPath, ref object pvarFileName) {
            if ((this.ocx == null)) {
                throw new System.Windows.Forms.AxHost.InvalidActiveXStateException("ExportToAttached", System.Windows.Forms.AxHost.ActiveXInvokeKind.MethodInvoke);
            }
            int returnValue = ((int)(this.ocx.ExportToAttached(lTypeId, lJobId, varColType, varColSize, varColName, varTempDBPath, ref pvarFileName)));
            return returnValue;
        }
        
        public virtual int TriggerPressOKEvent(int lEventId) {
            if ((this.ocx == null)) {
                throw new System.Windows.Forms.AxHost.InvalidActiveXStateException("TriggerPressOKEvent", System.Windows.Forms.AxHost.ActiveXInvokeKind.MethodInvoke);
            }
            int returnValue = ((int)(this.ocx.TriggerPressOKEvent(lEventId)));
            return returnValue;
        }
        
        public virtual void CloseWindows() {
            if ((this.ocx == null)) {
                throw new System.Windows.Forms.AxHost.InvalidActiveXStateException("CloseWindows", System.Windows.Forms.AxHost.ActiveXInvokeKind.MethodInvoke);
            }
            this.ocx.CloseWindows();
        }
        
        public virtual string Convert2UCase(string langid, float currency, short ntype) {
            if ((this.ocx == null)) {
                throw new System.Windows.Forms.AxHost.InvalidActiveXStateException("Convert2UCase", System.Windows.Forms.AxHost.ActiveXInvokeKind.MethodInvoke);
            }
            string returnValue = ((string)(this.ocx.Convert2UCase(langid, currency, ntype)));
            return returnValue;
        }
        
        public virtual void SetExportHandle(object ob) {
            if ((this.ocx == null)) {
                throw new System.Windows.Forms.AxHost.InvalidActiveXStateException("SetExportHandle", System.Windows.Forms.AxHost.ActiveXInvokeKind.MethodInvoke);
            }
            this.ocx.SetExportHandle(ob);
        }
        
        public virtual string Convert2UCaseEX(string langid, string currency, short ntype) {
            if ((this.ocx == null)) {
                throw new System.Windows.Forms.AxHost.InvalidActiveXStateException("Convert2UCaseEX", System.Windows.Forms.AxHost.ActiveXInvokeKind.MethodInvoke);
            }
            string returnValue = ((string)(this.ocx.Convert2UCaseEX(langid, currency, ntype)));
            return returnValue;
        }
        
        public virtual string SetLangID(string langid) {
            if ((this.ocx == null)) {
                throw new System.Windows.Forms.AxHost.InvalidActiveXStateException("SetLangID", System.Windows.Forms.AxHost.ActiveXInvokeKind.MethodInvoke);
            }
            string returnValue = ((string)(this.ocx.SetLangID(langid)));
            return returnValue;
        }
        
        public virtual int ExportToFileEx2(int lJobId, object varColType, object varColSize, object varColName, object varTempDBPath, int lCurrentPage, int lTotalPage) {
            if ((this.ocx == null)) {
                throw new System.Windows.Forms.AxHost.InvalidActiveXStateException("ExportToFileEx2", System.Windows.Forms.AxHost.ActiveXInvokeKind.MethodInvoke);
            }
            int returnValue = ((int)(this.ocx.ExportToFileEx2(lJobId, varColType, varColSize, varColName, varTempDBPath, lCurrentPage, lTotalPage)));
            return returnValue;
        }
        
        public virtual int GetTaskPageNum() {
            if ((this.ocx == null)) {
                throw new System.Windows.Forms.AxHost.InvalidActiveXStateException("GetTaskPageNum", System.Windows.Forms.AxHost.ActiveXInvokeKind.MethodInvoke);
            }
            int returnValue = ((int)(this.ocx.GetTaskPageNum()));
            return returnValue;
        }
        
        public virtual void AboutBox() {
            if ((this.ocx == null)) {
                throw new System.Windows.Forms.AxHost.InvalidActiveXStateException("AboutBox", System.Windows.Forms.AxHost.ActiveXInvokeKind.MethodInvoke);
            }
            this.ocx.AboutBox();
        }
        
        protected override void CreateSink() {
            try {
                this.eventMulticaster = new AxPrintControlEventMulticaster(this);
                this.cookie = new System.Windows.Forms.AxHost.ConnectionPointCookie(this.ocx, this.eventMulticaster, typeof(PRINTCONTROLLib._DPrintControlEvents));
            }
            catch (System.Exception ) {
            }
        }
        
        protected override void DetachSink() {
            try {
                this.cookie.Disconnect();
            }
            catch (System.Exception ) {
            }
        }
        
        protected override void AttachInterfaces() {
            try {
                this.ocx = ((PRINTCONTROLLib._DPrintControl)(this.GetOcx()));
            }
            catch (System.Exception ) {
            }
        }
        
        internal void RaiseOnSettingChanged(object sender, _DPrintControlEvents_SettingChangedEvent e) {
            if ((this.SettingChanged != null)) {
                this.SettingChanged(sender, e);
            }
        }
        
        internal void RaiseOnBeginPrinting(object sender, _DPrintControlEvents_BeginPrintingEvent e) {
            if ((this.BeginPrinting != null)) {
                this.BeginPrinting(sender, e);
            }
        }
        
        internal void RaiseOnPrinting(object sender, _DPrintControlEvents_PrintingEvent e) {
            if ((this.Printing != null)) {
                this.Printing(sender, e);
            }
        }
        
        internal void RaiseOnEndPrinting(object sender, System.EventArgs e) {
            if ((this.EndPrinting != null)) {
                this.EndPrinting(sender, e);
            }
        }
        
        internal void RaiseOnPressOK(object sender, _DPrintControlEvents_PressOKEvent e) {
            if ((this.PressOK != null)) {
                this.PressOK(sender, e);
            }
        }
    }
    
    public delegate void _DPrintControlEvents_SettingChangedEventHandler(object sender, _DPrintControlEvents_SettingChangedEvent e);
    
    public class _DPrintControlEvents_SettingChangedEvent {
        
        public object varLocalSettings;
        
        public object varModuleSettings;
        
        public _DPrintControlEvents_SettingChangedEvent(object varLocalSettings, object varModuleSettings) {
            this.varLocalSettings = varLocalSettings;
            this.varModuleSettings = varModuleSettings;
        }
    }
    
    public delegate void _DPrintControlEvents_BeginPrintingEventHandler(object sender, _DPrintControlEvents_BeginPrintingEvent e);
    
    public class _DPrintControlEvents_BeginPrintingEvent {
        
        public short jobs;
        
        public short fromPage;
        
        public short toPage;
        
        public short copies;
        
        public bool cancel;
        
        public _DPrintControlEvents_BeginPrintingEvent(short jobs, short fromPage, short toPage, short copies, bool cancel) {
            this.jobs = jobs;
            this.fromPage = fromPage;
            this.toPage = toPage;
            this.copies = copies;
            this.cancel = cancel;
        }
    }
    
    public delegate void _DPrintControlEvents_PrintingEventHandler(object sender, _DPrintControlEvents_PrintingEvent e);
    
    public class _DPrintControlEvents_PrintingEvent {
        
        public short page;
        
        public bool cancel;
        
        public _DPrintControlEvents_PrintingEvent(short page, bool cancel) {
            this.page = page;
            this.cancel = cancel;
        }
    }
    
    public delegate void _DPrintControlEvents_PressOKEventHandler(object sender, _DPrintControlEvents_PressOKEvent e);
    
    public class _DPrintControlEvents_PressOKEvent {
        
        public object varLocalSettings;
        
        public object varModuleSettings;
        
        public _DPrintControlEvents_PressOKEvent(object varLocalSettings, object varModuleSettings) {
            this.varLocalSettings = varLocalSettings;
            this.varModuleSettings = varModuleSettings;
        }
    }
    
    [System.Runtime.InteropServices.ClassInterface(System.Runtime.InteropServices.ClassInterfaceType.None)]
    public class AxPrintControlEventMulticaster : PRINTCONTROLLib._DPrintControlEvents {
        
        private AxPrintControl parent;
        
        public AxPrintControlEventMulticaster(AxPrintControl parent) {
            this.parent = parent;
        }
        
        public virtual void SettingChanged(object varLocalSettings, object varModuleSettings) {
            _DPrintControlEvents_SettingChangedEvent settingchangedEvent = new _DPrintControlEvents_SettingChangedEvent(varLocalSettings, varModuleSettings);
            this.parent.RaiseOnSettingChanged(this.parent, settingchangedEvent);
        }
        
        public virtual void BeginPrinting(short jobs, short fromPage, short toPage, short copies, ref bool cancel) {
            _DPrintControlEvents_BeginPrintingEvent beginprintingEvent = new _DPrintControlEvents_BeginPrintingEvent(jobs, fromPage, toPage, copies, cancel);
            this.parent.RaiseOnBeginPrinting(this.parent, beginprintingEvent);
            cancel = beginprintingEvent.cancel;
        }
        
        public virtual void Printing(short page, ref bool cancel) {
            _DPrintControlEvents_PrintingEvent printingEvent = new _DPrintControlEvents_PrintingEvent(page, cancel);
            this.parent.RaiseOnPrinting(this.parent, printingEvent);
            cancel = printingEvent.cancel;
        }
        
        public virtual void EndPrinting() {
            System.EventArgs endprintingEvent = new System.EventArgs();
            this.parent.RaiseOnEndPrinting(this.parent, endprintingEvent);
        }
        
        public virtual void PressOK(object varLocalSettings, object varModuleSettings) {
            _DPrintControlEvents_PressOKEvent pressokEvent = new _DPrintControlEvents_PressOKEvent(varLocalSettings, varModuleSettings);
            this.parent.RaiseOnPressOK(this.parent, pressokEvent);
        }
    }
}
