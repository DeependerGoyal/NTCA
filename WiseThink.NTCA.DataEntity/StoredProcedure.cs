﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WiseThink
{
    public static class StoredProcedure
    {
        //Declare By Zahir for Login Module
        #region StoredProcedure for login module

            public static string spLogin = "spLogin";
            public static string spInsertLoginTime = "spInsertLoginTime";
            public static string spUpdateLogoutTime = "spUpdateLogoutTime";
            public static string spInsertUnsuccessfulLoginDetails = "spInsertUnsuccessfulLoginDetails";
            public static string spIsUserLocked = "spIsUserLocked";
            public static string spDeleteLoginErrorInfo = "spDeleteLoginErrorInfo";
            public static string spIsUserExists = "spIsUserExists";
            public static string spUpdateTemporaryPassword = "spUpdateTemporaryPassword";
            //Declare by Indu for Login Module.
            public static string spIsUserInactive = "spIsUserInactive";

        #endregion

        public static string InsertUpdateLoginErrorInfo = "InsertUpdateLoginErrorInfo";
        public static string GetLoginErrorInfo = "getLoginErrorInfo";
        public static string CheckUserRoles = "checkUserRoles";
        public static string GetUserCredentials = "getUserCredentials";

        public static string InsertAuditTrailInfo = "InsertAuditTrailInfo";
        public static string GetAuditTrailInfo = "GetAuditTrailInfo";
        public static string GetLoginHistory = "GetLoginHistory";
        public static string spGetAdditionalAPOTotal = "spGetAdditionalAPOTotal";

        #region StoredProcedure for manage activities
        public static string spAddCategory = "spAddCategory";
        public static string spAddActivity = "spAddActivity";
        public static string spAddActivityItem = "spAddActivityItem";
        public static string spAddSubActivityItem = "spAddSubActivityItem";
        public static string spGetActivities = "spGetActivities";
        public static string spGetActivittItems = "spGetActivittItems";
        public static string spGetSubActivittItems = "spGetSubActivittItems";
        public static string spAddActivitySubItems = "spAddActivitySubItems";
        public static string spGetActivitySubItemList = "spGetActivitySubItemList";
        public static string spRelevantAPODocumentList = "spRelevantAPODocumentList";
        public static string spGetActivityItemListForAddNewSubItem = "spGetActivityItemListForAddNewSubItem";
       // public static string spGetSubItems = "spGetSubItems";
        #endregion

        #region StoredProcedure for user registration module

        public static string spAddUser = "spCreateUser";
        public static string spEditUser = "spEditUser";
        public static string spGetUserList = "spGetUserList";
        public static string spGetLastUser = "spGetLastUser";
        public static string spGetUserDetails = "spGetUserDetails";
        public static string spGetUserMasterData = "spGetUserMasterData";
        public static string spGetRole = "spGetRole";
        public static string spGetGender = "spGetGender";
        public static string spGetTitle = "spGetTitle";
        public static string spGetSecurityQuestion = "spGetSecurityQuestion";
        public static string spGetCountry = "spGetCountry";
        public static string spGetState = "spGetState";
        public static string spGetDistrict = "spGetDistrict";
        public static string spGetDistrictBasedOnState = "spGetDistrictBasedOnState";
        public static string spGetCurrentPassword = "spGetCurrentPassword";
        public static string spChangePassword = "spChangePassword";
        public static string spGetLoggedInUserId = "spGetLoggedInUserId";
        public static string spGetTigerReserveState = "spGetTigerReserveState";
        public static string spEditProfile = "spEditProfile";
        public static string spGetAllNTCAUsersEmail = "spGetAllNTCAUsersEmail";
        public static string spGetAllNTCAANDCWLWEmail = "spGetAllNTCAANDCWLWEmail";
        #endregion

        #region Reports stored procedures
        public static string Proc_Recognition_EvaluationDoneReport = "Proc_Recognition_EvaluationDoneReport";
        public static string GetDataForRenewal = "GetDataForRenewal";
        public static string GetCityTypeZooForState = "GetCityTypeZooForState";
        public static string GetTypeZooForCitys = "GetTypeZooForCitys";
        public static string Proc_Recognition_DoneReport = "Proc_Recognition_DoneReport";
        public static string GetEvaluationDueReport = "GetEvaluationDueReport";
        public static string EvaluatorGetAssignedByZooID = "Evaluator_GetAssignedByZooID";
        public static string EvaluatorGetAssignedByAppID = "Evaluator_GetAssignedByAppID";
        public static string GetRecognitionReport = "GetRecognitionReport";
        public static string ZooGetReport = "ZooDetail_GetReport";

        #endregion

        #region Strored Procedures for State Master
        public static string spAddState = "spAddState";
        public static string spEditState = "spEditState";
        public static string spGetStateList = "spGetStateList";
        #endregion
        #region Strored Procedures for Tiger Reserve Master
        public static string spGetStatesAndFeildDirectors = "spGetStatesAndFeildDirectors";
        public static string spAddTigerReserve = "spAddTigerReserve";
        public static string spEditTigerReserve = "spEditTigerReserve";
        public static string spGetTigerReserveList = "spGetTigerReserveList";
        public static string spGetTigerReserve = "spGetTigerReserve";
        public static string spGetTigerReserveName = "spGetTigerReserveName";
        public static string spGetTigerReserveBasedOnState = "spGetTigerReserveBasedOnState";
        public static string spGetNonRecurringAndRecurringRatio = "spGetNonRecurringAndRecurringRatio";
        public static string spUpdateNonRecurringAndRecurringRatio = "spUpdateNonRecurringAndRecurringRatio";
        #endregion
        #region Stored Prucedures for Alerts
        public static string spGetAlerts = "spGetAlerts";
        public static string spGetUserNameList = "spGetUserNameList";
        public static string spSendAlert = "spSendAlert";
        public static string spGetEmailAddress = "spGetEmailAddress";
        public static string spGetMultipleEmailAddress = "spGetMultipleEmailAddress";
        public static string spGetAllFieldDirectorUsersEmail = "spGetAllFieldDirectorUsersEmail";
        #endregion
        #region Manage Documents
        public static string spAddEditDocument = "spAddEditDocument";
        public static string spGetUploadedDocuments = "spGetUploadedDocuments";
        
        #endregion

        #region APO related Stored Procedure 
        public static string spGetDashboardForFD = "spGetDashboardForFD";
        public static string spGetLoggedInUserStateId = "spGetLoggedInUserStateId";
        public static string spGetDashboardForCWW = "spGetDashboardForCWW";
        public static string spGetDashboardForNTCA = "spGetDashboardForNTCA";
        public static string spGetDashboardForAdmin = "spGetDashboardForAdmin";
        public static string spGetAPOFormatData = "spGetAPOFormatData";
        public static string spSubmitAPO = "spSubmitAPO";
        public static string spModifyAPO = "spModifyAPO";
        public static string spGetAPODraftData = "spGetAPODraftData";
        public static string spGetAPODraftData_New = "spGetAPODraftData_New";
        public static string spGetGPSDetailsByItemID = "spGetGPSByITEMIDandTigerReserveID";
        public static string spGetAPOForEdit = "spGetAPOForEdit";
        public static string GetChildRecordDetails = "GetChildRecordDetails";
        public static string UpdateChildRecords = "UpdateChildRecords";
        public static string DeleteChildRecords = "DeleteChildRecords";
        public static string spUpdateAPO = "spUpdateAPO";
        public static string spViewAPOForFD = "spViewAPOForFD";
        public static string spGetLoggedInUserTigerReserveId = "spGetLoggedInUserTigerReserveId";
        public static string spGetAPOForApproval = "spGetAPOForApproval";
        public static string spGetStateIdTigerReserveIdAndFinancialYear = "spGetStateIdTigerReserveIdAndFinancialYear";
        public static string spGetCuurntFinancialYearApoId = "spGetCuurntFinancialYearApoId";
        public static string spGetPreviousFinancialYearApoId = "spGetPreviousFinancialYearApoId";
        public static string spViewAPOForPFY = "spViewAPOForPFY";
        public static string spGetApprovedAPOTitle = "spGetApprovedAPOTitle";
        public static string spGetAPODueForSubmission = "spGetAPODueForSubmission";
        public static string spAllowAPODueForSubmission = "spAllowAPODueForSubmission";
        public static string spGetQuarterlyReportFormatDataForCWWANDOfficerBYPeriod = "spGetQuarterlyReportFormatDataForCWWANDOfficerBYPeriod";
        public static string spAllowAdditionalAPODueForSubmission = "spAllowAdditionalAPODueForSubmission";
        public static string spAllowSubmissionAfterDueDate = "spAllowSubmissionAfterDueDate";
        public static string spDeleteApoEntry = "spDeleteApoEntry";
        public static string spAddGPS = "spAddGPS";
        public static string spAddGPS_FD = "spAddGPS_FD";
        public static string spGetGPS = "spGetGPS";
        public static string spUpdateGPS = "spUpdateGPS";
        public static string spDeleteGPS = "spDeleteGPS";
        public static string spGetSubItemDetail = "spGetSubItemDetail";
        public static string spGetSubItemDetailsFromAdditionalAPO = "spGetSubItemDetailsFromAdditionalAPO";
        public static string spGetSubItems = "spGetSubItems";
        public static string spUpdateActivitySubItems = "spUpdateActivitySubItems";
        public static string spGetSubItemListItemWise = "spGetSubItemListItemWise";
        public static string spGetNumberDaysToFillApo = "spGetNumberDaysToFillApo";
        public static string spGetExistFileUploadedName = "spGetExistFileUploadedName";
        public static string spViewSubItemDetail = "spViewSubItemDetail";
        public static string spGetSubItemsForView = "spGetSubItemsForView";
        public static string spAddSubItemInAPO = "spAddSubItemInAPO";
        public static string spAddSubItemInAdditionalAPO = "spAddSubItemInAdditionalAPO";
        public static string spGetDeleteEntryStatus = "spGetDeleteEntryStatus";
        #endregion 

        #region Manage Activity related stored procedure
        public static string spGetActivityMasterData = "spGetActivityMasterData";
        public static string spUpdateActivity = "spUpdateActivity";
        public static string spUpdateActivityItem = "spUpdateActivityItem";
        public static string spGetAreaActivityData = "spGetAreaActivityData";
        public static string spGetActivityItems = "spGetActivityItems";

        #endregion
        #region Obligation related stored procedure
        public static string spGetFDObligationFormat = "spGetFDObligationFormat";
        public static string spGetCWWObligationFormat = "spGetCWWObligationFormat";
        public static string spSubmitObligationsForFD = "spSubmitObligationsForFD";
        public static string spSubmitObligationsForCWW = "spSubmitObligationsForCWW";
        public static string spUpdateFDObligationstatus = "spUpdateFDObligationstatus";
        public static string spUpdateCWWObligationstatus = "spUpdateCWWObligationstatus";
        public static string spGetFDObligations = "spGetFDObligations";
        public static string spGetCWWObligations = "spGetCWWObligations";
        public static string spGetUserStateId = "spGetUserStateId";
        public static string spViewFDObligations = "spViewFDObligations";
        public static string spViewCWWObligations = "spViewCWWObligations";
        public static string spGetStateAndTigerReserveId = "spGetStateAndTigerReserveId";
        #endregion 
        #region Manage Designations
        public static string spGetDesignation = "spGetDesignation";
        public static string spAddDesignation = "spAddDesignation";
        public static string spEditDesignation = "spEditDesignation";
        public static string spDeleteDesignation = "spDeleteDesignation";
        #endregion
        #region Manage Obligations
        public static string spGetObligationFor = "spGetObligationFor";
        public static string spGetObligationMaster = "spGetObligationMaster";
        public static string spAddObligation = "spAddObligation";
        public static string spEditObligation = "spEditObligation";
        public static string spDeleteObligation = "spDeleteObligation";
        #endregion

        #region Quraterly Report
        public static string spGetQuarter = "spGetQuarter";
        public static string spGetQuarterlyReportFormatData = "spGetQuarterlyReportFormatData";
        public static string spGetQuarterlyReportFormatDataForCWWANDOfficer = "spGetQuarterlyReportFormatDataForCWWANDOfficer";
        public static string spSubmitQuarterlyReport = "spSubmitQuarterlyReport";
        public static string spModifyQuarterlyReport = "spModifyQuarterlyReport";
        public static string spGetQuarterlyReportDraftDataByMonths = "spGetQuarterlyReportDraftDataByMonths";
        public static string spGetQuarterlyReportDraftData = "spGetQuarterlyReportDraftData";
        public static string spFetchExpenditureReports = "spFetchExpenditureReports";
        public static string spGetCurrentYear = "spGetCurrentYear";
        public static string spGetDataforActivityWise = "spGetDataforActivityWise";
        public static string spGetDataforActivityItemWise = "spGetDataforActivityItemWise";
        public static string spGetDataforSubItemWise = "spGetDataforSubItemWise";
        public static string spGetDataforTigerReserveWise = "spGetDataforTigerReserveWise";
        public static string spGetDataforStateWise = "spGetDataforStateWise";
        #endregion
        //
        #region Manage CheckList
        public static string spGetFDCheckListFormat = "spGetFDCheckListFormat";
        public static string spSubmitCheckList = "spSubmitCheckList";
        public static string spGetCheckListDraftData = "spGetCheckListDraftData";
        //public static string spEditObligation = "spEditObligation";
        //public static string spDeleteObligation = "spDeleteObligation";
        public static string spForwardAPOToCWW = "spForwardAPOToCWW";
        public static string spChecckObligationsAndAnspentAmountSettled = "spChecckObligationsAndAnspentAmountSettled";
        public static string spGetTigerReserveApoCount = "spGetTigerReserveApoCount";
        public static string spIsAllowedAfterDueDate = "spIsAllowedAfterDueDate";
        public static string spGetParticularTigerReserveName = "spGetParticularTigerReserveName";
        public static string spGetUCAndProvisionalUC = "spGetUCAndProvisionalUC";
        #endregion

        #region Update APO Status
        public static string spGetStatusList = "spGetStatusList";
        public static string spGetCurrentAPOStatus = "spGetCurrentAPOStatus";
        public static string spRegionalOfficerDiaryNumber = "spRegionalOfficerDiaryNumber";
        public static string spUpdateAPOStatus = "spUpdateAPOStatus";
        public static string spGetAPOFileId = "spGetAPOFileId";
        public static string spChecckCWWObligations = "spChecckCWWObligations";
        #endregion

        #region Feedback
        public static string spGetFDFeedbackFormat = "spGetFDFeedbackFormat";
        public static string spGetCWWFeedbackFormat = "spGetCWWFeedbackFormat";
        public static string spSubmitFeedbackForFD = "spSubmitFeedbackForFD";
        public static string spSubmitFeedbackForCWW = "spSubmitFeedbackForCWW";
        public static string spGetFDFeedback = "spGetFDFeedback";
        public static string spGetCWWFeedback = "spGetCWWFeedback";
        public static string spGetTigerReserveIdStateId = "spGetStateAndTigerReserveId";
        #endregion 
        #region Utilization Certificate
        public static string spGetUCDetails = "spGetUCDetails";
        public static string spUploadProvisionalUC = "spUploadProvisionalUC";
        public static string spUploadFinalUC = "spUploadFinalUC";
        #endregion

        #region TigerReserve Details
        public static string spGetTigerReserveMasterData = "spGetTigerReserveMasterData";
        public static string spEditTigerReserveDetails = "spEditTigerReserveDetails";
        public static string spGetTigerReserveDetails = "spGetTigerReserveDetails";
        #endregion
       
        #region Manage Installments
        public static string spEditInstallments = "spEditInstallments";
        public static string spGetInstallments = "spGetInstallments";
        #endregion

        #region Settled Unspent amount via adjustment, revalidation and spillover
        public static string spGetUnspentActivitiesList = "spGetUnspentActivitiesList";
        public static string spSettledUnspent = "spSettledUnspent";
        #endregion

        #region Additional APO
        public static string spGetAdditionalAPODraftData = "spGetAdditionalAPODraftData";
        public static string spSubmitAdditionalAPO = "spSubmitAdditionalAPO";
        public static string spModifyAdditionalAPO = "spModifyAdditionalAPO";
        public static string spGetAdditionalAPOForEdit = "spGetAdditionalAPOForEdit";
        public static string spDeleteAdditionalApoEntry = "spDeleteAdditionalApoEntry";
        public static string spAddGPSAdditionalApo = "spAddGPSAdditionalApo";
        public static string spGetAdditionalApoGPS = "spGetAdditionalApoGPS";
        public static string spUpdateAdditionalApoGPS = "spUpdateAdditionalApoGPS";
        public static string spDeleteAdditionalApoGPS = "spDeleteAdditionalApoGPS";
        #endregion

        #region Monitor central and state share
        public static string spGetCentralStateShare = "spGetCentralStateShare";
        public static string spCentralStateFundReleaseDetails = "spCentralStateFundReleaseDetails";
        public static string spUpdateCentralFirstReleased = "spUpdateCentralFirstReleased";
        public static string spUpdateCentralSecondReleased = "spUpdateCentralSecondReleased";
        public static string spUpdateStateFirstReleased = "spUpdateStateFirstReleased";
        public static string spUpdateStateSecondReleased = "spUpdateStateSecondReleased";
        public static string spGetFinnalUcFileName = "spGetFinnalUcFileName";
        #endregion

        #region Manage CSS PT Guidelines
        public static string spGetCSSPTGuidelines = "spGetCSSPTGuidelines";
        public static string spEditCSSPTGuideline = "spEditCSSPTGuideline";
        public static string spAddGuideline = "spAddGuideline";
        public static string spDeleteGuideline = "spDeleteGuideline";
        #endregion

        public static string spUpdateDiaryNumber = "spUpdateDiaryNumber";

        public static string spSelectRatio = "spSelectRatio";

        public static string spGetAPOAmount = "spGetAPOAmount";

        #region to show Apo title statewise (for CWW)

        public static string spGetApprovedAPOTitleforCWW = "spGetApprovedAPOTitleforCWW";

        #endregion


        public static string spGetAPOTotal = "spGetAPOTotal";

    }
}