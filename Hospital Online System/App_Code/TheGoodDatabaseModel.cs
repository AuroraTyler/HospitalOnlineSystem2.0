﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

public partial class AppointmentTable
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public AppointmentTable()
    {
        this.PrescriptionTables = new HashSet<PrescriptionTable>();
        this.TestTables = new HashSet<TestTable>();
    }

    public int AppointmentId { get; set; }
    public int DoctorId { get; set; }
    public int PatientId { get; set; }
    public System.DateTime AppointmentDate { get; set; }
    public System.TimeSpan AppointmentTime { get; set; }
    public string Description { get; set; }
    public string Cause { get; set; }
    public string Diagnosis { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<PrescriptionTable> PrescriptionTables { get; set; }
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<TestTable> TestTables { get; set; }
    public virtual DoctorTable DoctorTable { get; set; }
    public virtual PatientTable PatientTable { get; set; }
}

public partial class DepartmentTable
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public DepartmentTable()
    {
        this.DoctorTables = new HashSet<DoctorTable>();
    }

    public int DepartmentId { get; set; }
    public int HospitalId { get; set; }
    public string Specialization { get; set; }
    public string DepartmentEmail { get; set; }
    public string DepartmentPhone { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<DoctorTable> DoctorTables { get; set; }
    public virtual HospitalTable HospitalTable { get; set; }
}

public partial class DoctorTable
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public DoctorTable()
    {
        this.AppointmentTables = new HashSet<AppointmentTable>();
        this.PatientTables = new HashSet<PatientTable>();
        this.PrescriptionTables = new HashSet<PrescriptionTable>();
        this.TestTables = new HashSet<TestTable>();
    }

    public int DoctorId { get; set; }
    public int HospitalID { get; set; }
    public int DepartmentId { get; set; }
    public string Name { get; set; }
    public string DoctorUserName { get; set; }
    public string DoctorPassword { get; set; }
    public System.DateTime DateofBirth { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<AppointmentTable> AppointmentTables { get; set; }
    public virtual DepartmentTable DepartmentTable { get; set; }
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<PatientTable> PatientTables { get; set; }
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<PrescriptionTable> PrescriptionTables { get; set; }
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<TestTable> TestTables { get; set; }
    public virtual HospitalTable HospitalTable { get; set; }
}

public partial class EmailTable
{
    public int EmailId { get; set; }
    public string EmailText { get; set; }
    public string SenderUserName { get; set; }
    public string RecipientUserName { get; set; }
    public System.DateTime EmailDate { get; set; }
}

public partial class HospitalTable
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public HospitalTable()
    {
        this.DepartmentTables = new HashSet<DepartmentTable>();
        this.DoctorTables = new HashSet<DoctorTable>();
    }

    public int HospitalId { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string ContactEmail { get; set; }
    public string ContactPhone { get; set; }
    public string ZipCode { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<DepartmentTable> DepartmentTables { get; set; }
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<DoctorTable> DoctorTables { get; set; }
}

public partial class PatientTable
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public PatientTable()
    {
        this.AppointmentTables = new HashSet<AppointmentTable>();
        this.PrescriptionTables = new HashSet<PrescriptionTable>();
        this.TestTables = new HashSet<TestTable>();
    }

    public int PatientId { get; set; }
    public int DoctorId { get; set; }
    public string PatientUserName { get; set; }
    public string PatientPassword { get; set; }
    public string Name { get; set; }
    public System.DateTime DateofBirth { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string ZipCode { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<AppointmentTable> AppointmentTables { get; set; }
    public virtual DoctorTable DoctorTable { get; set; }
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<PrescriptionTable> PrescriptionTables { get; set; }
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<TestTable> TestTables { get; set; }
}

public partial class PrescriptionTable
{
    public int PresriptionID { get; set; }
    public int PatientID { get; set; }
    public int DoctorID { get; set; }
    public int AppointmentID { get; set; }
    public Nullable<int> TestID { get; set; }
    public string MedicationName { get; set; }
    public string Dosage { get; set; }
    public System.DateTime RenewalDate { get; set; }

    public virtual AppointmentTable AppointmentTable { get; set; }
    public virtual DoctorTable DoctorTable { get; set; }
    public virtual PatientTable PatientTable { get; set; }
    public virtual TestTable TestTable { get; set; }
}

public partial class TestTable
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public TestTable()
    {
        this.PrescriptionTables = new HashSet<PrescriptionTable>();
    }

    public int TestID { get; set; }
    public int AppointmentID { get; set; }
    public int PatientID { get; set; }
    public int DoctorID { get; set; }
    public System.DateTime TestDate { get; set; }
    public string TestTime { get; set; }
    public string Conclusion { get; set; }

    public virtual AppointmentTable AppointmentTable { get; set; }
    public virtual DoctorTable DoctorTable { get; set; }
    public virtual PatientTable PatientTable { get; set; }
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<PrescriptionTable> PrescriptionTables { get; set; }
}
