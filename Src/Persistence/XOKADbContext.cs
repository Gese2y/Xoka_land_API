using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Application.Common.Interfaces;
using Common;
using Domain.Common;
using XOKA.Domain.Entities.view;

namespace Persistence
{
    public class XOKADbContext : DbContext, IXOKADbContext
    {
        private readonly ICurrentUserService _currentUserService;
        private readonly IDateTime _dateTime;

        public XOKADbContext(DbContextOptions<XOKADbContext> options)
            : base(options)
        {
        }

        public XOKADbContext(
            DbContextOptions<XOKADbContext> options, 
            ICurrentUserService currentUserService,
            IDateTime dateTime)
            : base(options)
        {
            _currentUserService = currentUserService;
            _dateTime = dateTime;
        }

        #region Finance

        //public virtual DbSet<Proc_Account_ProposeLoadAll> Proc_Account_ProposeLoadAll { get; set; }
        //public virtual DbSet<Proc_Account_ProposeLoadByPrimaryKey> Proc_Account_ProposeLoadByPrimaryKey { get; set; }
        //public virtual DbSet<Proc_Account_ProposeLoadAll> Proc_Account_ProposeLoadAll { get; set; }
        //public virtual DbSet<Proc_Account_ProposeLoadAll> Proc_Account_ProposeLoadAll { get; set; }
        //public virtual DbSet<Proc_Account_ProposeLoadAll> Proc_Account_ProposeLoadAll { get; set; }
        //public virtual DbSet<Proc_Account_ProposeLoadAll> Proc_Account_ProposeLoadAll { get; set; }
        //public virtual DbSet<Proc_Account_ProposeLoadAll> Proc_Account_ProposeLoadAll { get; set; }
        //public virtual DbSet<Proc_Account_ProposeLoadAll> Proc_Account_ProposeLoadAll { get; set; }
        //public virtual DbSet<Proc_Account_ProposeLoadAll> Proc_Account_ProposeLoadAll { get; set; }
        //public virtual DbSet<Proc_Account_ProposeLoadAll> Proc_Account_ProposeLoadAll { get; set; }
        //public virtual DbSet<Proc_Account_ProposeLoadAll> Proc_Account_ProposeLoadAll { get; set; }
        //public virtual DbSet<Proc_Account_ProposeLoadAll> Proc_Account_ProposeLoadAll { get; set; }
        //public virtual DbSet<Proc_Account_ProposeLoadAll> Proc_Account_ProposeLoadAll { get; set; }
        //public virtual DbSet<Proc_Account_ProposeLoadAll> Proc_Account_ProposeLoadAll { get; set; }
        //public virtual DbSet<Proc_Account_ProposeLoadAll> Proc_Account_ProposeLoadAll { get; set; }
        //public virtual DbSet<Proc_Account_ProposeLoadAll> Proc_Account_ProposeLoadAll { get; set; }
        //public virtual DbSet<Proc_Account_ProposeLoadAll> Proc_Account_ProposeLoadAll { get; set; }
        //public virtual DbSet<Proc_Account_ProposeLoadAll> Proc_Account_ProposeLoadAll { get; set; }
        //public virtual DbSet<Proc_Account_ProposeLoadAll> Proc_Account_ProposeLoadAll { get; set; }
        //public virtual DbSet<Proc_Account_ProposeLoadAll> Proc_Account_ProposeLoadAll { get; set; }

        #endregion

        // view
        public DbSet<ViewWorkinfo> ViewWorkinfo { get; set; }
        public DbSet<View_jobopportunityapi> View_jobopportunityapi { get; set; }
        public DbSet<View_Sub_city_Job_Assignment_Transactionwithorgandopp> View_Sub_city_Job_Assignment_Transactionwithorgandopp { get; set; }
        public DbSet<View_Job_Assignment_transactionwithorg> View_Job_Assignment_transactionwithorg { get; set; }
        public DbSet<View_vitaleage> View_vitaleage { get; set; }
        public DbSet<View_DARBYTIN> View_DARBYTIN { get; set; }
        public DbSet<View_shareholderdetailbydar> View_shareholderdetailbydar { get; set; } 
        public DbSet<View_darforshareprice> View_darforshareprice { get; set; } 
        public DbSet<view__job_positionbyparent> view__job_positionbyparent { get; set; }
        public DbSet<view_Null_parent_job_position> view_Null_parent_job_position { get; set; }
        public DbSet<View_Apliction_by_username_and_service> View_Apliction_by_username_and_service { get; set; }
        public DbSet<View_appliction_by_username> View_appliction_by_username { get; set; } 
        public DbSet<View_Job_Match> View_Job_Match { get; set; }
        public DbSet<View_jobOpprtunityfilterbycity> View_jobOpprtunityfilterbycity { get; set; }
        public DbSet<View_Exam_Result_Certificat> View_Exam_Result_Certificat { get; set; } 
        public DbSet<View_woreda_for_SuportingService> View_woreda_for_SuportingService { get; set; } 
        public DbSet<View_OCAC_Exam_Cad_IDForExam_Result> View_OCAC_Exam_Cad_IDForExam_Result { get; set; } 
        public DbSet<View_BatchwithEnrollment> View_BatchwithEnrollment { get; set; }
        public DbSet<ViewMKTProdIO> ViewMKTProdIO { get; set; }
        public DbSet<View_Application_Json> View_Application_Json { get; set; }
        public DbSet<View_StackholderswithEnterprise_Registration> View_StackholderswithEnterprise_Registration { get; set; }
        public DbSet<ViewBatch> Viewbatch { get; set; }
        public DbSet<View_examplan> View_examplan { get; set; }   
        public DbSet<View_Job_Assignment_transaction> View_Job_Assignment_transaction { get; set; } 
        public DbSet<View_jobassignment_transaction> View_jobassignment_transaction { get; set; }
        public DbSet<View_Unemployment_Education_Experience> View_Unemployment_Education_Experience { get; set; }
        public DbSet<View_Job_Matchdesendingorder> View_Job_Matchdesendingorder { get; set; }  
        public DbSet<View_Sub_city_Job_Assignment_Transaction> View_Sub_city_Job_Assignment_Transaction { get; set; }
        public DbSet<View_jobMachingFilterqualifyAllparameter> View_jobMachingFilterqualifyAllparameter { get; set; }
        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries<AuditableEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreatedBy = _currentUserService.UserId;
                        entry.Entity.Created = _dateTime.Now;
                        break;
                    case EntityState.Modified:
                        entry.Entity.LastModifiedBy = _currentUserService.UserId;
                        entry.Entity.LastModified = _dateTime.Now;
                        break;
                }
            }

            return base.SaveChangesAsync(cancellationToken);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(XOKADbContext).Assembly);

            modelBuilder
            .Entity<ViewWorkinfo>(eb =>
            {
                eb.HasNoKey();
                eb.ToView("View_Work_info");
                eb.Property(v => v.UserId).HasColumnName("UserId");
                eb.Property(v => v.UserName).HasColumnName("UserName");
                eb.Property(v => v.department_name).HasColumnName("department_name");
                eb.Property(v => v.Registration_code).HasColumnName("Registration_code");
                eb.Property(v => v.name_en).HasColumnName("name_en");
                eb.Property(v => v.organization_code).HasColumnName("organization_code");
            });
            modelBuilder
           .Entity<View_jobMachingFilterqualifyAllparameter>(eb =>
           {
               eb.HasNoKey();
               eb.ToView("View_jobMachingFilterqualifyAllparameterStep7");
               eb.Property(v => v.Job_Opportunity_ID).HasColumnName("Job_Opportunity_ID");
               eb.Property(v => v.Woreda).HasColumnName("Woreda");
               eb.Property(v => v.Sub_City).HasColumnName("Sub_City");
               eb.Property(v => v.QualifyBYAllParameter).HasColumnName("QualifyBYAllParameter");
               eb.Property(v => v.Date_Expires).HasColumnName("Date_Expires");
          
           });
            modelBuilder

           .Entity<View_StackholderswithEnterprise_Registration>(eb =>
           {
               eb.HasNoKey();
               eb.ToView("View_StackholderswithEnterprise_Registration");
               eb.Property(v => v.Stakeholder_TIN).HasColumnName("Stakeholder_TIN");
               eb.Property(v => v.MSE_Code).HasColumnName("MSE_Code");
               eb.Property(v => v.Type_Of_Stakeholder).HasColumnName("Type_Of_Stakeholder");
          
           });

            modelBuilder
            .Entity<ViewBatch>(eb =>
            {
                eb.HasNoKey();
                eb.ToView("View_Batch_program_provider");
                eb.Property(v => v.Code).HasColumnName("Code");
                eb.Property(v => v.Year).HasColumnName("Year");
                eb.Property(v => v.Start_Date).HasColumnName("Start_Date");
                eb.Property(v => v.End_Date).HasColumnName("End_Date");
                eb.Property(v => v.program_name).HasColumnName("program_name");
                eb.Property(v => v.Type).HasColumnName("Type");
                eb.Property(v => v.Level).HasColumnName("Level");
                eb.Property(v => v.provider_name).HasColumnName("provider_name");
                eb.Property(v => v.Capacity).HasColumnName("Capacity");
                eb.Property(v => v.ProviderCode).HasColumnName("ProviderCode");
            });
            modelBuilder
           .Entity<View_examplan>(eb =>
           {
               eb.HasNoKey();
               eb.ToView("View_examplan");
               eb.Property(v => v.Exam_ID).HasColumnName("Exam_ID");
               eb.Property(v => v.Name).HasColumnName("Name");
               eb.Property(v => v.Pass_Mark).HasColumnName("Pass_Mark");
               eb.Property(v => v.Centor_Code).HasColumnName("Centor_Code");
               eb.Property(v => v.Exam_center_name).HasColumnName("Exam_center_name");
               eb.Property(v => v.Address).HasColumnName("Address");
               eb.Property(v => v.Venue).HasColumnName("Venue");
               eb.Property(v => v.OS_ID).HasColumnName("OS_ID");
               eb.Property(v => v.Os_Name).HasColumnName("Os_Name");
               eb.Property(v => v.Start_Date).HasColumnName("Start_Date");
           });
            modelBuilder
          .Entity<View_Unemployment_Education_Experience>(eb =>
          {
              eb.HasNoKey();
              eb.ToView("View_Unemployment_Education_Experience");
              eb.Property(v => v.ID).HasColumnName("ID");
              eb.Property(v => v.Full_Name).HasColumnName("Full_Name");
              eb.Property(v => v.Gender).HasColumnName("Gender");
              eb.Property(v => v.Sex).HasColumnName("Sex");
              eb.Property(v => v.Age).HasColumnName("Age");
              eb.Property(v => v.Status).HasColumnName("Status");
              eb.Property(v => v.Education_Level).HasColumnName("Education_Level");
              eb.Property(v => v.Education_Level_Name).HasColumnName("Education_Level_Name");
              eb.Property(v => v.Eduction_Types).HasColumnName("Eduction_Types");
              eb.Property(v => v.english_description).HasColumnName("english_description");
              eb.Property(v => v.Short_Term_Training).HasColumnName("Short_Term_Training");
              eb.Property(v => v.Eduction_Types).HasColumnName("Eduction_Types");
              eb.Property(v => v.Num_Work_Exp).HasColumnName("Num_Work_Exp");
              eb.Property(v => v.Physical_Condition).HasColumnName("Physical_Condition");
              eb.Property(v => v.Zone_SubCity).HasColumnName("Zone_SubCity");
              eb.Property(v => v.Woreda_Kebele).HasColumnName("Woreda_Kebele");
              eb.Property(v => v.Parent).HasColumnName("Parent");
          });
            modelBuilder
         .Entity<View_Job_Matchdesendingorder>(eb =>
         {
             eb.HasNoKey();
             eb.ToView("View_Job_Matchdesendingorder");
             eb.Property(v => v.Job_Match_ID).HasColumnName("Job_Match_ID");
             eb.Property(v => v.Transaction_ID).HasColumnName("Transaction_ID");
             eb.Property(v => v.Kebele_ID).HasColumnName("Kebele_ID");
             eb.Property(v => v.Officer_Proposed_Kebele_ID).HasColumnName("Officer_Proposed_Kebele_ID");
             eb.Property(v => v.Officer_Justification).HasColumnName("Officer_Justification");
             eb.Property(v => v.Date_Proposed).HasColumnName("Date_Proposed");
             eb.Property(v => v.Is_Approved).HasColumnName("Is_Approved");
             eb.Property(v => v.Approval_Justification_Doc).HasColumnName("Approval_Justification_Doc");
             eb.Property(v => v.Is_Hired).HasColumnName("Is_Hired");
             eb.Property(v => v.Remarks).HasColumnName("Remarks");
             eb.Property(v => v.Full_Name).HasColumnName("Full_Name");
             eb.Property(v => v.Gender).HasColumnName("Gender");
             eb.Property(v => v.Sex).HasColumnName("Sex");
             eb.Property(v => v.Age).HasColumnName("Age");
             eb.Property(v => v.Education_Level).HasColumnName("Education_Level");
             eb.Property(v => v.Education_Level_Name).HasColumnName("Education_Level_Name");
             eb.Property(v => v.Eduction_Types).HasColumnName("Eduction_Types");
             eb.Property(v => v.english_description).HasColumnName("english_description");
             eb.Property(v => v.Eduction_Types).HasColumnName("Eduction_Types");
             eb.Property(v => v.Zone_SubCity).HasColumnName("Zone_SubCity");
             eb.Property(v => v.Woreda_Kebele).HasColumnName("Woreda_Kebele");
             eb.Property(v => v.Parent).HasColumnName("Parent");
         });
            modelBuilder
         .Entity<View_jobassignment_transaction>(eb =>
         {
             eb.HasNoKey();
             eb.ToView("View_jobassignment_transaction");
             eb.Property(v => v.Name).HasColumnName("Name");
             eb.Property(v => v.Woreda).HasColumnName("Woreda");
             eb.Property(v => v.Number_Of_Person).HasColumnName("Number_Of_Person");
             eb.Property(v => v.Approval_Justification_Doc).HasColumnName("Approval_Justification_Doc");
             eb.Property(v => v.Job_Position).HasColumnName("Job_Position");
             eb.Property(v => v.name_am).HasColumnName("name_am");
             eb.Property(v => v.name_amsubcity).HasColumnName("name_amsubcity");
             eb.Property(v => v.organization_code).HasColumnName("organization_code");
             eb.Property(v => v.Job_Opportunity_ID).HasColumnName("Job_Opportunity_ID");
             eb.Property(v => v.Stakeholder_TIN).HasColumnName("Stakeholder_TIN");
             eb.Property(v => v.Position_Name).HasColumnName("Position_Name");
             eb.Property(v => v.Transaction_ID).HasColumnName("Transaction_ID");
             eb.Property(v => v.organization_codeforsubcity).HasColumnName("organization_codeforsubcity");
            
         });
            modelBuilder
         .Entity<View_Job_Match>(eb =>
         {
             eb.HasNoKey();
             eb.ToView("View_Job_Match");
             eb.Property(v => v.Job_Match_ID).HasColumnName("Job_Match_ID");
             eb.Property(v => v.Transaction_ID).HasColumnName("Transaction_ID");
             eb.Property(v => v.Kebele_ID).HasColumnName("Kebele_ID");
             eb.Property(v => v.Officer_Proposed_Kebele_ID).HasColumnName("Officer_Proposed_Kebele_ID");
             eb.Property(v => v.Officer_Justification).HasColumnName("Officer_Justification");
             eb.Property(v => v.Date_Proposed).HasColumnName("Date_Proposed");
             eb.Property(v => v.Is_Approved).HasColumnName("Is_Approved");
             eb.Property(v => v.Approval_Justification_Doc).HasColumnName("Approval_Justification_Doc");
             eb.Property(v => v.Is_Hired).HasColumnName("Is_Hired");
             eb.Property(v => v.Remarks).HasColumnName("Remarks");
             eb.Property(v => v.Full_Name).HasColumnName("Full_Name");
         });
            modelBuilder
        .Entity<View_Exam_Result_Certificat>(eb =>
        {
            eb.HasNoKey();
            eb.ToView("View_Exam_Result_Certificat");
            eb.Property(v => v.ID).HasColumnName("ID");
            eb.Property(v => v.Exam_Result_Id).HasColumnName("Exam_Result_Id");
            eb.Property(v => v.TEVET_Program_ID).HasColumnName("TEVET_Program_ID");
            eb.Property(v => v.Date_Issued).HasColumnName("Date_Issued");
            eb.Property(v => v.Expired_Date).HasColumnName("Expired_Date");
            eb.Property(v => v.Is_Summitted_To_candidate).HasColumnName("Is_Summitted_To_candidate");
            eb.Property(v => v.Student).HasColumnName("Student");
            eb.Property(v => v.Exam_center).HasColumnName("Exam_center");
            eb.Property(v => v.Exam_Name).HasColumnName("Exam_Name");
            eb.Property(v => v.Start_Date).HasColumnName("Start_Date");
            eb.Property(v => v.Enrolment_ID).HasColumnName("Enrolment_ID"); 
            eb.Property(v => v.ID_No).HasColumnName("ID_No");
            eb.Property(v => v.First_Name_AM).HasColumnName("First_Name_AM");
            eb.Property(v => v.Middle_Name_AM).HasColumnName("Middle_Name_AM");
            eb.Property(v => v.Last_Name_AM).HasColumnName("Last_Name_AM");
            eb.Property(v => v.Program_Name).HasColumnName("Program_Name");
            eb.Property(v => v.Program).HasColumnName("Program");
            eb.Property(v => v.OCAC_Candiate).HasColumnName("OCAC_Candiate");
            eb.Property(v => v.Licence_Id).HasColumnName("Licence_Id");
            eb.Property(v => v.Result_In_Number).HasColumnName("Result_In_Number");
            eb.Property(v => v.Result_In_Text).HasColumnName("Result_In_Text");
        });
            modelBuilder
       .Entity<View_OCAC_Exam_Cad_IDForExam_Result>(eb =>
       {
           eb.HasNoKey();
           eb.ToView("View_OCAC_Exam_Cad_IDForExam_Result");
           eb.Property(v => v.Student).HasColumnName("Student");
           eb.Property(v => v.Exam_center).HasColumnName("Exam_center");
           eb.Property(v => v.Exam_Name).HasColumnName("Exam_Name");
           eb.Property(v => v.Start_Date).HasColumnName("Start_Date");
           eb.Property(v => v.Enrolment_ID).HasColumnName("Enrolment_ID");
           eb.Property(v => v.ID_No).HasColumnName("ID_No");
           eb.Property(v => v.First_Name_AM).HasColumnName("First_Name_AM");
           eb.Property(v => v.Middle_Name_AM).HasColumnName("Middle_Name_AM");
           eb.Property(v => v.Last_Name_AM).HasColumnName("Last_Name_AM");
           eb.Property(v => v.Program_Name).HasColumnName("Program_Name");
           eb.Property(v => v.Program).HasColumnName("Program");
           eb.Property(v => v.OCAC_Candiate).HasColumnName("OCAC_Candiate");
           eb.Property(v => v.Licence_Id).HasColumnName("Licence_Id");
       });  
            modelBuilder
       .Entity<View_woreda_for_SuportingService>(eb =>
       {
           eb.HasNoKey();
           eb.ToView("View_woreda_for_SuportingService");
           eb.Property(v => v.Kebele_ID).HasColumnName("Kebele_ID");
           eb.Property(v => v.Woreda).HasColumnName("Woreda");
           eb.Property(v => v.Zone).HasColumnName("Zone");
       });
            modelBuilder
      .Entity<View_BatchwithEnrollment>(eb =>
      {
          eb.HasNoKey();
          eb.ToView("View_BatchwithEnrollment");
          eb.Property(v => v.ProviderCode).HasColumnName("ProviderCode");
          eb.Property(v => v.Capac).HasColumnName("Capac");
          eb.Property(v => v.Student_code).HasColumnName("Student_code");
          eb.Property(v => v.Start_Date).HasColumnName("Start_Date");
          eb.Property(v => v.Year).HasColumnName("Year");
          eb.Property(v => v.End_Date).HasColumnName("End_Date");
          eb.Property(v => v.Code).HasColumnName("Code");
          eb.Property(v => v.Type).HasColumnName("Type");
          eb.Property(v => v.Level).HasColumnName("Level");
          eb.Property(v => v.program_name).HasColumnName("Program_Name");
          eb.Property(v => v.provider_name).HasColumnName("provider_name");
          eb.Property(v => v.ID).HasColumnName("ID");
          eb.Property(v => v.EID).HasColumnName("EID");
      });
            modelBuilder
    .Entity<View_Application_Json>(eb =>
    {
        eb.HasNoKey();
        eb.ToView("View_Application_Json");
        eb.Property(v => v.application_number).HasColumnName("application_number");
        eb.Property(v => v.tasks_task_code).HasColumnName("tasks_task_code");
        eb.Property(v => v.Valuexml).HasColumnName("Valuexml");
        eb.Property(v => v.description_en).HasColumnName("description_en");
        eb.Property(v => v.task_type_code).HasColumnName("task_type_code");
        eb.Property(v => v.application_code).HasColumnName("application_code");
        eb.Property(v => v.process_detail_code).HasColumnName("process_detail_code");
        eb.Property(v => v.services_service_code).HasColumnName("services_service_code");
    }); 
            modelBuilder
    .Entity<View_appliction_by_username>(eb =>
    {
        eb.HasNoKey();
        eb.ToView("View_appliction_by_username");
        eb.Property(v => v.application_number).HasColumnName("application_number");
        eb.Property(v => v.UserName).HasColumnName("UserName");
    });   
            modelBuilder
    .Entity<View_Apliction_by_username_and_service>(eb =>
    {
        eb.HasNoKey();
        eb.ToView("View_Apliction_by_username_and_service");
        eb.Property(v => v.application_number).HasColumnName("application_number");
        eb.Property(v => v.UserName).HasColumnName("UserName");
        eb.Property(v => v.application_code).HasColumnName("application_code");
        eb.Property(v => v.UserId).HasColumnName("UserId"); 
        eb.Property(v => v.services_service_code).HasColumnName("services_service_code");
        eb.Property(v => v.organization_code).HasColumnName("organization_code");
    });
            modelBuilder
   .Entity<view__job_positionbyparent>(eb =>
   {
       eb.HasNoKey();
        eb.ToView("view__job_positionbyparent");
       eb.Property(v => v.Job_Position_ID).HasColumnName("Job_Position_ID");
       eb.Property(v => v.Position_Name).HasColumnName("Position_Name");
       eb.Property(v => v.Parent_ID).HasColumnName("Parent_ID");
       eb.Property(v => v.Sector).HasColumnName("Sector");
       eb.Property(v => v.Sub_Sector).HasColumnName("Sub_Sector");
       eb.Property(v => v.Field_of_Bussines).HasColumnName("Field_of_Bussines");
   }); 
            modelBuilder
   .Entity<view_Null_parent_job_position>(eb =>
   {
       eb.HasNoKey();
        eb.ToView("view_Null_parent_job_position");
       eb.Property(v => v.Job_Position_ID).HasColumnName("Job_Position_ID");
       eb.Property(v => v.Position_Name).HasColumnName("Position_Name");
       eb.Property(v => v.Parent_ID).HasColumnName("Parent_ID");
       eb.Property(v => v.Sector).HasColumnName("Sector");
       eb.Property(v => v.Sub_Sector).HasColumnName("Sub_Sector");
       eb.Property(v => v.Field_of_Bussines).HasColumnName("Field_of_Bussines");
   });   
            modelBuilder
   .Entity<View_darforshareprice>(eb =>
   {
       eb.HasNoKey();
        eb.ToView("View_darforshareprice");
       eb.Property(v => v.DAR_NO).HasColumnName("DAR_NO ");
       eb.Property(v => v.Share_Price).HasColumnName("Share_Price ");
   });  
            modelBuilder
   .Entity<View_vitaleage>(eb =>
   {
       eb.HasNoKey();
        eb.ToView("View_vitaleage");
       eb.Property(v => v.Age).HasColumnName("Age");
       eb.Property(v => v.ID).HasColumnName("ID");
   }); 
            modelBuilder
   .Entity<View_shareholderdetailbydar>(eb =>
   {
       eb.HasNoKey();
        eb.ToView("View_shareholderdetailbydar");
       eb.Property(v => v.ID).HasColumnName("ID");
       eb.Property(v => v.TIN).HasColumnName("TIN");
       eb.Property(v => v.Shere_Type).HasColumnName("Shere_Type");
       eb.Property(v => v.Transfer_Date).HasColumnName("Transfer_Date");
       eb.Property(v => v.DAR_NO).HasColumnName("DAR_NO ");
       eb.Property(v => v.No_Share).HasColumnName("No_Share");
       eb.Property(v => v.Share_Price).HasColumnName("Share_Price");
       eb.Property(v => v.Total_Share).HasColumnName("Total_Share");
       eb.Property(v => v.Doc_ID).HasColumnName("Doc_ID");
       eb.Property(v => v.Full_Name).HasColumnName("Full_Name");
       eb.Property(v => v.YEAR).HasColumnName("YEAR");
       eb.Property(v => v.Parent).HasColumnName("Parent");
       eb.Property(v => v.IS_Current).HasColumnName("IS_Current");
       eb.Property(v => v.Kebele_ID).HasColumnName("Kebele_ID");
       eb.Property(v => v.Is_Manager).HasColumnName("Is_Manager");
   }); 
            modelBuilder
   .Entity<View_Job_Assignment_transaction>(eb =>
   {
       eb.HasNoKey();
        eb.ToView("View_Job_Assignment_transaction");
       eb.Property(v => v.Transaction_ID).HasColumnName("Transaction_ID");
       eb.Property(v => v.Job_Opportunity_ID).HasColumnName("Job_Opportunity_ID");
       eb.Property(v => v.Woreda).HasColumnName("Woreda");
       eb.Property(v => v.Number_Of_Person).HasColumnName("Number_Of_Person");
   });
            modelBuilder
   .Entity<View_Sub_city_Job_Assignment_Transaction>(eb =>
   {
       eb.HasNoKey();
        eb.ToView("View_Sub_city_Job_Assignment_Transaction");
       eb.Property(v => v.Transaction_ID).HasColumnName("Transaction_ID");
       eb.Property(v => v.Job_Opportunity_ID).HasColumnName("Job_Opportunity_ID");
       eb.Property(v => v.Sub_City).HasColumnName("Sub_City");
       eb.Property(v => v.Number_Of_Person).HasColumnName("Number_Of_Person");
       eb.Property(v => v.Created_By).HasColumnName("Created_By");
   });
        modelBuilder
   .Entity<View_Job_Assignment_transactionwithorg>(eb =>
   {
       eb.HasNoKey();
        eb.ToView("View_Job_Assignment_transactionwithorg");
       eb.Property(v => v.Transaction_ID).HasColumnName("Transaction_ID");
       eb.Property(v => v.Job_Opportunity_ID).HasColumnName("Job_Opportunity_ID");
       eb.Property(v => v.Sub_City).HasColumnName("Sub_City");
       eb.Property(v => v.Position_Name).HasColumnName("Position_Name");
        eb.Property(v => v.subcityname).HasColumnName("subcityname");
       eb.Property(v => v.woredaname).HasColumnName("woredaname");
        eb.Property(v => v.Approval_Justification_Doc).HasColumnName("Approval_Justification_Doc");
       eb.Property(v => v.Number_Of_Person).HasColumnName("Number_Of_Person");
       eb.Property(v => v.Stakeholder_TIN).HasColumnName("Stakeholder_TIN");
   });modelBuilder
   .Entity<View_Sub_city_Job_Assignment_Transactionwithorgandopp>(eb =>
   {
       eb.HasNoKey();
        eb.ToView("View_Sub_city_Job_Assignment_Transactionwithorgandopp");
       eb.Property(v => v.Transaction_ID).HasColumnName("Transaction_ID");
       eb.Property(v => v.Job_Opportunity_ID).HasColumnName("Job_Opportunity_ID");
       eb.Property(v => v.Sub_City).HasColumnName("Sub_City");
       eb.Property(v => v.Position_Name).HasColumnName("Position_Name");
        eb.Property(v => v.name_am).HasColumnName("name_am");
       eb.Property(v => v.Stakeholder_TIN).HasColumnName("Stakeholder_TIN");
        eb.Property(v => v.Approval_Justification_Doc).HasColumnName("Approval_Justification_Doc");
       eb.Property(v => v.Number_Of_Person).HasColumnName("Number_Of_Person");
       eb.Property(v => v.Created_By).HasColumnName("Created_By");
   });

            modelBuilder
   .Entity<View_DARBYTIN>(eb =>
   {
       eb.HasNoKey();
       eb.ToView("View_DARBYTIN");
       eb.Property(v => v.DAR_NO).HasColumnName("DAR_NO");
       eb.Property(v => v.Name_EN).HasColumnName("Name_EN");
       eb.Property(v => v.Name_AM).HasColumnName("Name_AM");
       eb.Property(v => v.DAR_Type).HasColumnName("DAR_Type");
       eb.Property(v => v.Doc_ID).HasColumnName("Doc_ID");
       eb.Property(v => v.IS_Signed).HasColumnName("IS_Signed");
       eb.Property(v => v.No_of_Copy).HasColumnName("No_of_Copy");
       eb.Property(v => v.Parent).HasColumnName("Parent");
       eb.Property(v => v.Licence_Id).HasColumnName("Licence_Id");
       eb.Property(v => v.Remark).HasColumnName("Remark");
       eb.Property(v => v.Temp_Name_ID).HasColumnName("Temp_Name_ID");
       eb.Property(v => v.Ownership_Type).HasColumnName("Ownership_Type");
       eb.Property(v => v.Scanned_Document).HasColumnName("Scanned_Document");
       eb.Property(v => v.Number_Of_Pages).HasColumnName("Number_Of_Pages");
       eb.Property(v => v.Share_Price).HasColumnName("Share_Price");
       eb.Property(v => v.TIN).HasColumnName("TIN");
   });
            modelBuilder
.Entity<View_jobOpprtunityfilterbycity>(eb =>
{
    eb.HasNoKey();
    eb.ToView("View_jobOpprtunityfilterbycity");
    eb.Property(v => v.Stakeholder_TIN).HasColumnName("Stakeholder_TIN");
    eb.Property(v => v.Name).HasColumnName("Name");
    eb.Property(v => v.Position_Name).HasColumnName("Position_Name");
    eb.Property(v => v.Job_Position).HasColumnName("Job_Position");
    eb.Property(v => v.Sub_City).HasColumnName("Sub_City");
    eb.Property(v => v.name_en).HasColumnName("name_en");
    eb.Property(v => v.name_am).HasColumnName("name_am");
    eb.Property(v => v.total_number_of_person).HasColumnName("total_number_of_person");
    eb.Property(v => v.Job_Opportunity_ID).HasColumnName("Job_Opportunity_ID");
    eb.Property(v => v.Result).HasColumnName("Result");
    eb.Property(v => v.Number_Of_Person).HasColumnName("Number_Of_Person");
    eb.Property(v => v.Subtraction_Result).HasColumnName("Subtraction_Result");
});  
            modelBuilder
.Entity<View_jobopportunityapi>(eb =>
{
    eb.HasNoKey();
        eb.ToView("View_jobopportunityapi");
      eb.Property(v => v.Position_Name).HasColumnName("Position_Name");
         eb.Property(v => v.Name).HasColumnName("Name");
         eb.Property(v => v.Job_Opportunity_ID).HasColumnName("Job_Opportunity_ID");
         eb.Property(v => v.Stakeholder_TIN).HasColumnName("Stakeholder_TIN");
         eb.Property(v => v.Job_Position).HasColumnName("Job_Position");
         eb.Property(v => v.Educ_Operand).HasColumnName("Educ_Operand");
         eb.Property(v => v.Educational_Level_ID).HasColumnName("Educational_Level_ID");
         eb.Property(v => v.Education_Type).HasColumnName("Education_Type");
         eb.Property(v => v.Work_Exp_Operand).HasColumnName("Work_Exp_Operand");
         eb.Property(v => v.Work_Experience_In_Years).HasColumnName("Work_Experience_In_Years");
         eb.Property(v => v.Gender_Criteria).HasColumnName("Gender_Criteria");
         eb.Property(v => v.Description).HasColumnName("Description");
         eb.Property(v => v.Type_Of_Hire).HasColumnName("Type_Of_Hire");
        eb.Property(v => v.Date_Posted).HasColumnName("Date_Posted");
        eb.Property(v => v.Date_Expires).HasColumnName("Date_Expires");
        eb.Property(v => v.Is_Active).HasColumnName("Is_Active");
         eb.Property(v => v.Remarks).HasColumnName("Remarks");
         eb.Property(v => v.Sector).HasColumnName("Sector");
         eb.Property(v => v.Sub_Sector).HasColumnName("Sub_Sector");
         eb.Property(v => v.Field_of_Business).HasColumnName("Field_of_Business");
        eb.Property(v => v.Date_of_sending_to_the_employer_office).HasColumnName("Date_of_sending_to_the_employer_office");
         eb.Property(v => v.gendername).HasColumnName("gendername");
         eb.Property(v => v.hiretypename).HasColumnName("hiretypename");
         eb.Property(v => v.educationidname).HasColumnName("educationidname");
    eb.Property(v => v.number_of_person_requird).HasColumnName("number_of_person_requird");
    eb.Property(v => v.WorkExpOperand).HasColumnName("WorkExpOperand");
    eb.Property(v => v.EducOperand).HasColumnName("EducOperand");
});
        }
    }
}
