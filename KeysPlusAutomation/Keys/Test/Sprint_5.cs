using Keys.Global;
using Keys.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keys.Test
{
    class Sprint_1
    {
        [TestFixture]
        [Category("Sprint_1")]
        class Sprint_1_Administration : Base
        {
            //Preethi/Reshma Maintenance CRUD
            #region Maintenance
            //[Test]
            //public void Maintenance_AddJob()
            //{
            //    test = extent.StartTest("Add Job for Property Manager ");
            //    Maintenance addjobobj = new Maintenance();
            //    addjobobj.AddJob();
            //}

            //[Test]
            //public void Maintenance_EditJob()
            //{
            //    test = extent.StartTest("Edit Job for Property Manager ");
            //    Maintenance jobobj = new Maintenance();
            //    jobobj.editjob();
            //}
            //[Test]
            //public void Maintenance_PickJob()
            //{
            //    test = extent.StartTest("Pick Job for Property Manager ");
            //    Maintenance jobobj = new Maintenance();
            //    jobobj.pickjob();
            //}

            //[Test]
            //public void Maintenance_JobStatus()
            //{
            //    test = extent.StartTest("Job Status for Property Manager ");
            //    Maintenance jobobj = new Maintenance();
            //    jobobj.jobstatus();
            //}
            ////Janani test
            //[Test]
            //public void Maintenance_pickJobJanani()
            //{
            //    test = extent.StartTest("Job Status for Property Manager ");
            //    Maintenance jobobj = new Maintenance();
            //    jobobj.pickJobJanani();
            //}


            ////  pickJobJanani
            ////Janani Code changes start here
            //[Test]
            //public void Maintenance_Job_Add()
            //{
            //    test = extent.StartTest("Add new Job");
            //    Maintenance jobAdd = new Maintenance();
            //    jobAdd.addNewJob();

            //}

            //[Test]
            //public void Maintenance_View_My_Quote()
            //{
            //    test = extent.StartTest("Add new Job");
            //    Maintenance viewMyQuote = new Maintenance();
            //    viewMyQuote.view_my_quote();
            //}
            ////Delete a new job
            ////[Test]
            ////public void Job_Delete()
            ////{
            ////    test = extent.StartTest("Delete added Job");
            ////    Maintenance jobAdd = new Maintenance();
            ////    jobAdd.delete_job_Open();

            ////}

            //////Delete a started job
            //////Delete a new job
            ////[Test]
            ////public void Job_Delete_Pending()
            ////{
            ////    test = extent.StartTest("Delete added Job");
            ////    Maintenance jobAdd = new Maintenance();
            ////    jobAdd.delete_job_Started();

            ////}

            ////Janani Code changes end here

            //[Test]
            //public void Maintenance_AddNewJob()
            //{
            //    test = extent.StartTest("Check Minimum/Maximum Lenght validation of Job Description field");
            //    Maintenance AddNewJob = new Maintenance();
            //    AddNewJob.ValidationsOfJobPropertyManager();

            //}
            //[Test]
            //public void Maintenance_DeleteJobFromPropertyManagerTest()
            //{
            //    test = extent.StartTest("Check delete record from the Maintenance job for Property Manager");
            //    Maintenance DeleteRecord = new Maintenance();
            //    DeleteRecord.DeleteJobFromMaintenance();
            //}
            ////Lewis Manage Job Property Manager View Quote
            //[Test]
            //public void Maintenance_ViewQuote1()
            //{
            //    test = extent.StartTest("Manage Job for Property Manager View Quote ");
            //    Maintenance jobobj = new Maintenance();
            //    jobobj.viewquote();
            //}
            //[Test]
            //public void Maintenance_DeletePending()
            //{
            //    test = extent.StartTest("Manage Job for Property Manager Delete Pending ");
            //    Maintenance jobobj = new Maintenance();
            //    jobobj.deletePending();
            //}
            #endregion
            //Preethi Admin
            #region
            [Test]
            public void Adminpage()
            {
                test = extent.StartTest("Admin page navigation");
                Admin adminpageobj = new Admin();
                adminpageobj.Adminpage();
            }
            [Test]
            public void Admin_Edit()
            {

                test = extent.StartTest("Editing user details");
                Admin editpageobj = new Admin();
                editpageobj.Adminpage();
                editpageobj.adminedit2();
            }
            [Test]
            public void Admin_Delete()
            {
                test = extent.StartTest("Deleting user details");
                Admin deletepageobj = new Admin();
                deletepageobj.Adminpage();
                deletepageobj.admindelete();
            }
            [Test]
            public void Adminfieldvalidation()
            {
                test = extent.StartTest("Field validations");
                Admin validationobj = new Admin();
                validationobj.Adminpage();

                validationobj.adminfieldval();
            }
            #endregion
            //Saranga Add New Property
            [Test]
            public void AddPropertyTest()
            {
                test = extent.StartTest("Check with the valid data to all input fields by clicking Submit button Add New Property");
                Property AddNew = new Property();
                AddNew.AddProperty();
            }
            #region max character
            //[Test]
            //public void Property_ValidateMaxlengthOfFields()
            //{
            //    test = extent.StartTest("Check Maximum length validation of Property Page text fields");
            //    Property TextBoxValidation = new Property();
            //    TextBoxValidation.CheckMaxCharaterLength();


            //}
            #endregion



            [Test]
            public void Register_CreateNewUser()
            {
                // creates a toggle for the given test, adds all log events under it    
                test = extent.StartTest("Register New Customer");
                Register obj = new Register();
                obj.register();

            }


            //Add Property_DetailValidation()

            [Test]
            public void AddProperty_DetailValidation()
            {
                // creates a toggle for the given test, adds all log events under it    
                test = extent.StartTest("Check data validation in Add New Property");
                //Create Proprty Obj and deletes
                Property PObj = new Property();
                PObj.PropertyDetailValidation();


            }
            //Delete a Property

            [Test]
            public void Property_Delete()
            {
                // creates a toggle for the given test, adds all log events under it    
                test = extent.StartTest("Check whether user able to Delete Property");
                //Create Proprty Obj and deletes
                Property delobj = new Property();
                delobj.DeleteProperty();


            }
            //Verify Cancel button in Delete Property Func

            [Test]
            public void Property_Cancel()
            {
                // creates a toggle for the given test, adds all log events under it    
                test = extent.StartTest("Check whether user able to Click Cancel operation in Delete Confirm");
                //Create Proprty Obj and deletes
                Property PObj = new Property();
                PObj.DeleteCancel();


            }

            //Apply for job with quote in marketplace
            [Test]
            public void Job_Apply()
            {
                // creates a toggle for the given test, adds all log events under it    
                test = extent.StartTest("Check whether user is able to apply for a job in marketplace");
                MarketPlace obj = new MarketPlace();
                obj.Apply_Quote_Job();
            }

            //Property Owner Onboarding
            [Test]
            public void owner_onboarding()
            {
                // creates a toggle for the given test, adds all log events under it
                test = extent.StartTest("Check whether property owner is able to complete Onboarding process");
                PropertyOwner_Onboarding obj = new PropertyOwner_Onboarding();
                obj.Property_OwnerOnboard_addtenant();
            }
            //service supplier onboarding
            [Test]

            public void servicesupplier_onboarding()
            {
                // creates a toggle for the given test, adds all log events under it
                test = extent.StartTest("Check whether service supplier is able to complete Onboarding process");
                ServiceSupplierOnboarding obj = new ServiceSupplierOnboarding();
                obj.ServiceProviderEnterAllDetails();
            }

            //tenant onboarding
            [Test]

            public void tenant_onboarding()
            {
                // creates a toggle for the given test, adds all log events under it
                test = extent.StartTest("Check whether tenant is able to complete Onboarding process");
                TenantOnboarding obj = new TenantOnboarding();
                obj.tenantonboard();
            }

            //add new job
            [Test]
            public void Addnewjob()
            {
                // creates a toggle for the given test, adds all log events under it
                test = extent.StartTest("Check whether owner is able to add new job to marketplace");
                Owners_Job_quotes obj = new Owners_Job_quotes();
                obj.Addnewjob();
            }
            //Add new Property
            [Test]
            public void Add_New_Property()
            {
                // creates a toggle for the given test, adds all log events under it
                test = extent.StartTest("Check with the valid data to all input fields by clicking Submit button Add New Property");
                NewProperty Add = new NewProperty();
                Add.AddnewProperty();
            }
            //Edit Property
            [Test]
            public void Edit_propety()
            {
                // creates a toggle for the given test, adds all log events under it
                test = extent.StartTest("Check whether the user is able to edit property");
                NewProperty Edit = new NewProperty();
                Edit.EditProperty();

            }
            // Delete Property
            [Test]
            public void Delete_Property()
            {
                // creates a toggle for the given test, adds all log events under it
                test = extent.StartTest("Check whether the user is able to edit property");
                NewProperty delete = new NewProperty();
                delete.DeleteProperty();
            }
            //Advanced search
            [Test]
            public void Advanced_Search()
            {
                // creates a toggle for the given test, adds all log events under it.
                test = extent.StartTest("Check whether the user is able to search for the property");
                Advanced_search search = new Advanced_search();
                search.Advancedsearch();
            }
            //Tenant Watchlist
            [Test]
            public void Tenant_Watchlist()
            {
                // creates a toggle for the given test, adds all log events under it.
                test = extent.StartTest("Check whether the user is able to access the watchlist functionality");
                Tenant_Watchlist watchlist = new Tenant_Watchlist();
                watchlist.TenantWatchlist();
            }
            
            [Test]
            public void SearchProperty()
            {
                test = extent.StartTest("Search for a Property");
                PO obj = new PO();
                obj.SearchProp();
            }

        }
    }
}
