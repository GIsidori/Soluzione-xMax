using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using DevExpress.Persistent.Base.General;

namespace xMax.Module.BusinessObjects.Database
{

    public partial class BaseEvent:IEvent
    {
        public BaseEvent(Session session) : base(session) { }

        [NonPersistent]
        [Browsable(false)]
        public virtual object AppointmentId => Oid;



        public override void AfterConstruction() { base.AfterConstruction(); }


        DateTime fStartOn;
        [NonPersistent]
        [Browsable(false)]
        public virtual DateTime StartOn
        {
            get { return fStartOn; }
            set { SetPropertyValue<DateTime>(nameof(StartOn), ref fStartOn, value); }
        }
        DateTime fEndOn;
        [Browsable(false)]
        public virtual DateTime EndOn
        {
            get { return fEndOn; }
            set { SetPropertyValue<DateTime>(nameof(EndOn), ref fEndOn, value); }
        }
        bool fAllDay;
        [Browsable(false)]
        public virtual bool AllDay
        {
            get { return fAllDay; }
            set { SetPropertyValue<bool>(nameof(AllDay), ref fAllDay, value); }
        }
        string fLocation;
        [Browsable(false)]
        public virtual string Location
        {
            get { return fLocation; }
            set { SetPropertyValue<string>(nameof(Location), ref fLocation, value); }
        }
        int fLabel;
        [Browsable(false)]
        public virtual int Label
        {
            get { return fLabel; }
            set { SetPropertyValue<int>(nameof(Label), ref fLabel, value); }
        }
        int fStatus;
        [Browsable(false)]
        public virtual int Status
        {
            get { return fStatus; }
            set { SetPropertyValue<int>(nameof(Status), ref fStatus, value); }
        }
        int fType;
        [Browsable(false)]
        public virtual int Type
        {
            get { return fType; }
            set { SetPropertyValue<int>(nameof(Type), ref fType, value); }
        }
        string fResourceId;
        [Browsable(false)]
        public virtual string ResourceId
        {
            get { return fResourceId; }
            set { SetPropertyValue<string>(nameof(ResourceId), ref fResourceId, value); }
        }
        string fSubject;
        [Browsable(false)]
        public virtual string Subject
        {
            get { return fSubject; }
            set { SetPropertyValue<string>(nameof(Subject), ref fSubject, value); }
        }
        string fDescription;
        [Browsable(false)]
        public virtual string Description
        {
            get { return fDescription; }
            set { SetPropertyValue<string>(nameof(Description), ref fDescription, value); }
        }

    }

}
