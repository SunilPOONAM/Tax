using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using TaxService.Resources;

namespace TaxService.Models
{
    public class TaxModel
    {       
        public Guid CustomerCode { get; set; }

        public string CustomerEmail { get; set; }

        public string Language { get; set; }

        [Display(Name = "FirstName", ResourceType = typeof(Resource))]
        [Required(ErrorMessageResourceType = typeof(Resource), ErrorMessageResourceName = "FirstNameRequired")]
        public string FirstName
        {
            get;
            set;
        }

        [Display(Name = "Department of the Treasury - Internal Revenue Service", ResourceType = typeof(Resource))]
        public string DeptName { get; set; }

        [Display(Name = "OMB Number", ResourceType = typeof(Resource))]
        public string OMBNumber { get; set; }

        [Display(Name = "Form", ResourceType = typeof(Resource))]
        public string Form { get; set; }

        [Display(Name = "13614-C", ResourceType = typeof(Resource))]
        public string Formnum { get; set; }

        [Display(Name = "(October 2020)", ResourceType = typeof(Resource))]
        public string Formocdate { get; set; }

        [Display(Name = "Intake/Interview & Quality Review Sheet", ResourceType = typeof(Resource))]
        public string Intakesheet { get; set; }

        [Display(Name = "You will need:", ResourceType = typeof(Resource))]
        public string Youwillbe { get; set; }

        [Display(Name = "Tax Information such as Forms W-2, 1099, 1098, 1095.", ResourceType = typeof(Resource))]
        public string taxinfosuch { get; set; }

        [Display(Name = "Social security cards or ITIN letters for all persons on your tax return.", ResourceType = typeof(Resource))]
        public string socialsecucard { get; set; }

        [Display(Name = "Picture ID (such as valid driver's license) for you and your spouse.", ResourceType = typeof(Resource))]
        public string pictureidfor { get; set; }

        [Display(Name = "Please complete pages 1-4 of this form.", ResourceType = typeof(Resource))]
        public string pleasecompt { get; set; }

        [Display(Name = "You are responsible for the information on your return. Please provide complete and accurate information.", ResourceType = typeof(Resource))]
        public string youareresponsi { get; set; }

        [Display(Name = "If you have questions, please ask the IRS-certified volunteer preparer.", ResourceType = typeof(Resource))]
        public string engl1 { get; set; }

        [Display(Name = "Volunteers are trained to provide high quality service and uphold the highest ethical standards.To report unethical behavior to the IRS, email us at", ResourceType = typeof(Resource))]
        public string engl2 { get; set; }

        [Display(Name = "wi.voltax@irs.gov", ResourceType = typeof(Resource))]
        public string engl3 { get; set; }

        [Display(Name = "Part I – Your Personal Information", ResourceType = typeof(Resource))]
        public string Part_first_your_personal_information { get; set; }

        [Display(Name = "(If you are filing a joint return, enter your names in the same order as last year’s return)", ResourceType = typeof(Resource))]
        public string If_uou_are_filling_a_joint_return { get; set; }

        [Display(Name = "Your first name", ResourceType = typeof(Resource))]
        public string Your_first_name { get; set; }

        [Display(Name = "M.I.", ResourceType = typeof(Resource))]
        public string M_I { get; set; }

        [Display(Name = "Last name", ResourceType = typeof(Resource))]
        public string Last_name { get; set; }

        [Display(Name = "Daytime telephone number", ResourceType = typeof(Resource))]
        public string Daytime_telephone_number { get; set; }

        [Display(Name = "Are you a U.S. citizen?", ResourceType = typeof(Resource))]
        public string Are_you_a_us_citizen { get; set; }

        [Display(Name = "Yes", ResourceType = typeof(Resource))]
        public string Yes { get; set; }

        [Display(Name = "No", ResourceType = typeof(Resource))]
        public string No { get; set; }

        [Display(Name = "Your spouse’s first name", ResourceType = typeof(Resource))]
        public string Your_spouse_first_name { get; set; }

        [Display(Name = "M.I.", ResourceType = typeof(Resource))]
        public string as4 { get; set; }

        [Display(Name = "Last name", ResourceType = typeof(Resource))]
        public string as5 { get; set; }

        [Display(Name = "Daytime telephone number", ResourceType = typeof(Resource))]
        public string as6 { get; set; }

        [Display(Name = "Is your spouse a U.S. citizen?", ResourceType = typeof(Resource))]
        public string Is_your_spouse_a_us_citizen { get; set; }

        [Display(Name = "Yes", ResourceType = typeof(Resource))]
        public string as8 { get; set; }

        [Display(Name = "No", ResourceType = typeof(Resource))]
        public string as9 { get; set; }

        [Display(Name = "Mailing address", ResourceType = typeof(Resource))]
        public string Mailing_address { get; set; }

        [Display(Name = "Apt #", ResourceType = typeof(Resource))]
        public string Apt { get; set; }

        [Display(Name = "City", ResourceType = typeof(Resource))]
        public string City { get; set; }

        [Display(Name = "State", ResourceType = typeof(Resource))]
        public string State { get; set; }

        [Display(Name = "ZIP Code", ResourceType = typeof(Resource))]
        public string Zip_code { get; set; }

        [Display(Name = "Your Date of Birth", ResourceType = typeof(Resource))]
        public string Your_date_of_birth { get; set; }

        [Display(Name = "Your job title", ResourceType = typeof(Resource))]
        public string Your_job_title { get; set; }

        [Display(Name = "Last year, were you:", ResourceType = typeof(Resource))]
        public string Last_year_were_you { get; set; }

        [Display(Name = "Totally and permanently disabled", ResourceType = typeof(Resource))]
        public string Totally_and_permanently_disabled { get; set; }

        [Display(Name = "Full-time student", ResourceType = typeof(Resource))]
        public string Full_time_student { get; set; }

        [Display(Name = "Legally blind", ResourceType = typeof(Resource))]
        public string Legally_blind { get; set; }

        [Display(Name = "Your spouse’s Date of Birth", ResourceType = typeof(Resource))]
        public string Your_spouse_date_of_birth { get; set; }

        [Display(Name = "Your spouse’s job title", ResourceType = typeof(Resource))]
        public string Your_spouse_job_title { get; set; }

        [Display(Name = "Last year, was your spouse:", ResourceType = typeof(Resource))]
        public string Last_year_was_your_spouse { get; set; }

        [Display(Name = "Totally and permanently disabled", ResourceType = typeof(Resource))]
        public string asdf4 { get; set; }

        [Display(Name = "Full-time student", ResourceType = typeof(Resource))]
        public string asdf5 { get; set; }

        [Display(Name = "Legally blind", ResourceType = typeof(Resource))]
        public string asdf6 { get; set; }

        [Display(Name = "Can anyone claim you or your spouse as a dependent?", ResourceType = typeof(Resource))]
        public string Can_anyone_claim_you_or_your { get; set; }

        [Display(Name = "Unsure", ResourceType = typeof(Resource))]
        public string Unsure { get; set; }

        [Display(Name = "Have you, your spouse, or dependents been a victim of tax related identity theft or been issued an Identity Protection PIN?", ResourceType = typeof(Resource))]
        public string Have_you_your_spouse_or_dependents_been_a { get; set; }

        [Display(Name = "Part II – Marital Status and Household Information", ResourceType = typeof(Resource))]
        public string Part_second_marital_status_and_household_information { get; set; }

        [Display(Name = "As of December 31, 2020, what was your marital status?", ResourceType = typeof(Resource))]
        public string As_of_december_thirtyfirst { get; set; }

        [Display(Name = "Never Married", ResourceType = typeof(Resource))]
        public string Never_married { get; set; }

        [Display(Name = "Married", ResourceType = typeof(Resource))]
        public string married { get; set; }

        [Display(Name = "(This includes registered domestic partnerships, civil unions, or other formal relationships under state law)", ResourceType = typeof(Resource))]
        public string This_includes_registered_domestic { get; set; }

        [Display(Name = "If Yes, Did you get married in 2020?", ResourceType = typeof(Resource))]
        public string If_yes_did_you_get_married { get; set; }

        [Display(Name = "Did you live with your spouse during any part of the last six months of 2020?", ResourceType = typeof(Resource))]
        public string Did_you_live_with_your_spouse_during_any { get; set; }

        [Display(Name = "Divorced", ResourceType = typeof(Resource))]
        public string Divorced { get; set; }

        [Display(Name = "Date of final decree", ResourceType = typeof(Resource))]
        public string Date_of_final_decree { get; set; }

        [Display(Name = "Legally Separated", ResourceType = typeof(Resource))]
        public string Legally_speparated { get; set; }

        [Display(Name = "Date of separate maintenance decre", ResourceType = typeof(Resource))]
        public string Date_of_separate_maintenance_decre { get; set; }

        [Display(Name = "Widowed", ResourceType = typeof(Resource))]
        public string Widowed { get; set; }

        [Display(Name = "Year of spouse’s death", ResourceType = typeof(Resource))]
        public string Year_of_spouse_deaths { get; set; }

        [Display(Name = "List the names below of", ResourceType = typeof(Resource))]
        public string List_the_name_below_of { get; set; }

        [Display(Name = "everyone", ResourceType = typeof(Resource))]
        public string Everyone { get; set; }

        [Display(Name = "who lived with you last year (other than your spouse)", ResourceType = typeof(Resource))]
        public string Who_lived_with_you_last_year { get; set; }

        [Display(Name = "If additional space is needed check here and list on page 3", ResourceType = typeof(Resource))]
        public string If_additional_space_is_needed_check_here { get; set; }

        [Display(Name = "anyone", ResourceType = typeof(Resource))]
        public string Anyone { get; set; }

        [Display(Name = "you supported but did not live with you last year", ResourceType = typeof(Resource))]
        public string You_support_but_did_not_live_with_you { get; set; }

        [Display(Name = "To be completed by a Certified Volunteer Preparer", ResourceType = typeof(Resource))]
        public string To_be_completed_by_a_certificate { get; set; }

        [Display(Name = "Name (first, last) Do not enter your name or spouse’s name below", ResourceType = typeof(Resource))]
        public string Name_first_and_last_do_not_enter_your { get; set; }

        [Display(Name = ".", ResourceType = typeof(Resource))]
        public string sc10 { get; set; }

        [Display(Name = "Date of Birth", ResourceType = typeof(Resource))]
        public string Date_of_births { get; set; }

        [Display(Name = "(mm/dd/yy)", ResourceType = typeof(Resource))]
        public string Date_format { get; set; }

        [Display(Name = "(b)", ResourceType = typeof(Resource))]
        public string dc3 { get; set; }

        [Display(Name = "Relationship to you (for  example:   son, daughter,  parent,  none, etc)", ResourceType = typeof(Resource))]
        public string Relationship_to_you_for_example { get; set; }

        [Display(Name = "(c)", ResourceType = typeof(Resource))]
        public string dc5 { get; set; }

        [Display(Name = "Number of  months lived in your home  last year", ResourceType = typeof(Resource))]
        public string Number_of_months_lived_in_your_home { get; set; }

        [Display(Name = "US  Citizen  (yes/no)", ResourceType = typeof(Resource))]
        public string Us_citizen_tes_or_no { get; set; }

        [Display(Name = "Resident of US, Canada, or Mexico last year (yes/no)", ResourceType = typeof(Resource))]
        public string Resident_of_us_canada_or_maxico { get; set; }

        [Display(Name = "Single or Married as of 12/31/20  (S/M)", ResourceType = typeof(Resource))]
        public string Single_or_married_as_of { get; set; }

        [Display(Name = "Full-time Student last year (yes/no)", ResourceType = typeof(Resource))]
        public string Full_time_student_last_year_yes_or_no { get; set; }

        [Display(Name = "Totally and Permanently Disabled (yes/no)", ResourceType = typeof(Resource))]
        public string Totally_and_permanently_disabled_yes_or_nos { get; set; }

        [Display(Name = "Is this person a qualifying child/relative of any other person? (yes/no)", ResourceType = typeof(Resource))]
        public string Is_this_person_a_qualifying { get; set; }

        [Display(Name = "Did this person  provide more than 50% of his/ her own support? (yes,no,n/a)", ResourceType = typeof(Resource))]
        public string Did_this_person_provide_more_than_fifty { get; set; }

        [Display(Name = "Did this person have less than $4,300 of income? (yes,no,n/a)", ResourceType = typeof(Resource))]
        public string Did_this_person_have_less_than_fortythree { get; set; }

        [Display(Name = "Did the taxpayer(s) provide more  than 50% of support for  this person? (yes/no/n/a)", ResourceType = typeof(Resource))]
        public string Did_the_taxpayers_provide_more_than_fiftypercent { get; set; }

        [Display(Name = "Did the  taxpayer(s)  pay more than half the cost of maintaining a home for this person? (yes/no)", ResourceType = typeof(Resource))]
        public string Did_the_taxpayers_pay_more_than_half_the_cost { get; set; }

        [Display(Name = "Catalog Number 52121E", ResourceType = typeof(Resource))]
        public string az7 { get; set; }

        [Display(Name = "www.irs.gov", ResourceType = typeof(Resource))]
        public string az8 { get; set; }

        [Display(Name = "Form 13614-C (Rev. 10-2020)", ResourceType = typeof(Resource))]
        public string az9 { get; set; }

        [Display(Name = "Check appropriate box for each question in each section", ResourceType = typeof(Resource))]
        public string Check_appropriate_box_for_each_question_in_each { get; set; }

        [Display(Name = "Part III – Income – Last Year, Did You (or Your Spouse) Receive", ResourceType = typeof(Resource))]
        public string Part_third_income_last_year_did_you { get; set; }

        [Display(Name = "Wages or Salary? (Form W-2)", ResourceType = typeof(Resource))]
        public string Wages_or_salary_form_w { get; set; }

        [Display(Name = "If yes, how many jobs did you have last year?", ResourceType = typeof(Resource))]
        public string If_yes_how_many_jobs_did_you_have_last_year { get; set; }

        [Display(Name = "Tip Income?", ResourceType = typeof(Resource))]
        public string Tip_income { get; set; }

        [Display(Name = "Scholarships? (Forms W-2, 1098-T)", ResourceType = typeof(Resource))]
        public string Scholarships_form_w_t { get; set; }

        [Display(Name = "Interest/Dividends from: checking/savings accounts, bonds, CDs, brokerage? (Forms 1099-INT, 1099-DIV)", ResourceType = typeof(Resource))]
        public string Interest_dividents_from_checking { get; set; }

        [Display(Name = "Refund of state/local income taxes? (Form 1099-G)", ResourceType = typeof(Resource))]
        public string Refund_of_state_local_income { get; set; }

        [Display(Name = "Alimony income or separate maintenance payments?", ResourceType = typeof(Resource))]
        public string Alimony_income_or_seprate_maintenence_payments { get; set; }

        [Display(Name = "Self-Employment income? (Form 1099-MISC, 1099-NEC, cash, virtual currency, or other property or services)", ResourceType = typeof(Resource))]
        public string Self_employment_income_form { get; set; }

        [Display(Name = "Cash/check/virtual currency payments, or other property or services for any work performed not reported on Forms W-2 or 1099?", ResourceType = typeof(Resource))]
        public string Cash_check_virtual_currency_payments { get; set; }

        [Display(Name = "Income (or loss) from the sale or exchange of Stocks, Bonds, Virtual Currency or Real Estate? (including your home) (Forms 1099-S,1099-B)", ResourceType = typeof(Resource))]
        public string Income_or_oloss_from_the_sale { get; set; }

        [Display(Name = "Disability income? (such as payments from insurance, or workers compensation) (Forms 1099-R, W-2)", ResourceType = typeof(Resource))]
        public string Disability_income_such { get; set; }

        [Display(Name = "Retirement income or payments from Pensions. Annuities, and or IRA? (Form 1099-R)", ResourceType = typeof(Resource))]
        public string Retriment_income_or_payments { get; set; }

        [Display(Name = "Unemployment Compensation? (Form 1099G)", ResourceType = typeof(Resource))]
        public string Unemployment_compensation { get; set; }

        [Display(Name = "Social Security or Railroad Retirement Benefits? (Forms SSA-1099, RRB-1099)", ResourceType = typeof(Resource))]
        public string Social_security_or_railroad_retirement { get; set; }

        [Display(Name = "Income (or loss) from Rental Property?", ResourceType = typeof(Resource))]
        public string Income_or_loss_for_rental_property { get; set; }

        [Display(Name = "Other income? (gambling, lottery, prizes, awards, jury duty, virtual currency, Sch K-1, royalties, foreign income, other property or services,", ResourceType = typeof(Resource))]
        public string Other_income_gamnling_lottery { get; set; }

        [Display(Name = "etc.)", ResourceType = typeof(Resource))]
        public string etc { get; set; }

        [Display(Name = "Specify", ResourceType = typeof(Resource))]
        public string Specify { get; set; }

        [Display(Name = "Unsure", ResourceType = typeof(Resource))]
        public string gb10 { get; set; }

        [Display(Name = "Part IV – Expenses – Last Year, Did You (or Your Spouse) Pay", ResourceType = typeof(Resource))]
        public string Part_four_expenses { get; set; }

        [Display(Name = "Alimony or separate maintenance payments? If yes, do you have the recipient’s SSN?", ResourceType = typeof(Resource))]
        public string Alimony_or_seprate_maintenance_payments_if { get; set; }

        [Display(Name = "Contributions to a retirement account?", ResourceType = typeof(Resource))]
        public string Contribution_to_a_retirement_account { get; set; }

        [Display(Name = "IRA", ResourceType = typeof(Resource))]
        public string Ira { get; set; }

        [Display(Name = "401K", ResourceType = typeof(Resource))]
        public string Fourhundredone_k { get; set; }

        [Display(Name = "Roth IRA", ResourceType = typeof(Resource))]
        public string Roth_ira { get; set; }

        [Display(Name = "Other", ResourceType = typeof(Resource))]
        public string Other { get; set; }

        [Display(Name = "College or post secondary educational expenses for yourself, spouse or dependents? (Form 1098-T)", ResourceType = typeof(Resource))]
        public string College_or_post_secondry_education { get; set; }

        [Display(Name = "Any of the following?", ResourceType = typeof(Resource))]
        public string Any_of_the_following { get; set; }

        [Display(Name = "Medical & Dental (including insurance premiums)", ResourceType = typeof(Resource))]
        public string Medical_and_dental_inculiding { get; set; }

        [Display(Name = "Mortgage Interest (Form 1098)", ResourceType = typeof(Resource))]
        public string Mortagage_interest { get; set; }

        [Display(Name = "Taxes (State, Real Estate, Personal Property, Sales)", ResourceType = typeof(Resource))]
        public string Taxes_state_real_estate_personal { get; set; }

        [Display(Name = "Charitable Contributions", ResourceType = typeof(Resource))]
        public string Charitable_contributions { get; set; }

        [Display(Name = "Child or dependent care expenses such as daycare?", ResourceType = typeof(Resource))]
        public string Child_or_dependent_care_expences { get; set; }

        [Display(Name = "For supplies used as an eligible educator such as a teacher, teacher’s aide, counselor, etc.?", ResourceType = typeof(Resource))]
        public string For_supplies_used_as_an_eligible { get; set; }

        [Display(Name = "Expenses related to self-employment income or any other income you received?", ResourceType = typeof(Resource))]
        public string Expences_related_to_self_employment_income { get; set; }

        [Display(Name = "Student loan interest? (Form 1098-E)", ResourceType = typeof(Resource))]
        public string Student_loan_interest { get; set; }

        [Display(Name = "Part V – Life Events – Last Year, Did You (or Your Spouse)", ResourceType = typeof(Resource))]
        public string Part_five_life_events { get; set; }

        [Display(Name = "Have a Health Savings Account? (Forms 5498-SA, 1099-SA, W-2 with code W in box 12)", ResourceType = typeof(Resource))]
        public string Have_a_helth_saving_account { get; set; }

        [Display(Name = "Have credit card or mortgage debt cancelled/forgiven by a lender or have a home foreclosure? (Forms 1099-C, 1099-A)", ResourceType = typeof(Resource))]
        public string Have_credit_card_or_mortgage_debt { get; set; }

        [Display(Name = "Adopt a child?", ResourceType = typeof(Resource))]
        public string Adopt_a_child { get; set; }

        [Display(Name = "Have Earned Income Credit, Child Tax Credit or American Opportunity Credit disallowed in a prior year? If yes, for which tax year?", ResourceType = typeof(Resource))]
        public string Have_earned_income_credit { get; set; }

        [Display(Name = "Purchase and install energy-efficient home items? (such as windows, furnace, insulation, etc.)", ResourceType = typeof(Resource))]
        public string Purchase_and_install_energy_efficant { get; set; }

        [Display(Name = "Receive the First Time Homebuyers Credit in 2008?", ResourceType = typeof(Resource))]
        public string Recive_the_first_time_homebuyers { get; set; }

        [Display(Name = "Make estimated tax payments or apply last year’s refund to this year’s tax? If so how much?", ResourceType = typeof(Resource))]
        public string Make_estimated_tax_payments { get; set; }

        [Display(Name = "File a federal return last year containing a “capital loss carryover” on Form 1040 Schedule D?", ResourceType = typeof(Resource))]
        public string File_a_federal_return_last_year { get; set; }

        [Display(Name = "Have health coverage through the Marketplace (Exchange)? [Provide Form 1095-A]", ResourceType = typeof(Resource))]
        public string Have_health_coverage_through_the { get; set; }

        [Display(Name = "Receive an Economic Impact Payment (stimulus) in 2020?", ResourceType = typeof(Resource))]
        public string Receive_an_economic_impact_payment { get; set; }

        [Display(Name = "Catalog Number 52121E", ResourceType = typeof(Resource))]
        public string kl9 { get; set; }

        [Display(Name = "www.irs.gov", ResourceType = typeof(Resource))]
        public string kl10 { get; set; }

        [Display(Name = "Form 13614-C (Rev. 10-2020)", ResourceType = typeof(Resource))]
        public string ed1 { get; set; }

        [Display(Name = "Additional Information and Questions Related to the Preparation of Your Return", ResourceType = typeof(Resource))]
        public string Additional_information_and_question_related { get; set; }

        [Display(Name = "Provide an email address (optional) (this email address will not be used for contacts from the Internal Revenue Service)", ResourceType = typeof(Resource))]
        public string Provide_an_email_address { get; set; }

        [Display(Name = "Presidential Election Campaign Fund (If you check a box, your tax or refund will not change)", ResourceType = typeof(Resource))]
        public string Presidental_election_campaign_fund { get; set; }

        [Display(Name = "Check here if you, or your spouse if filing jointly, want $3 to go to this fund", ResourceType = typeof(Resource))]
        public string Chech_here_if_you_or_your_spouse_if { get; set; }

        [Display(Name = "You", ResourceType = typeof(Resource))]
        public string You { get; set; }

        [Display(Name = "Spouse", ResourceType = typeof(Resource))]
        public string Spouse { get; set; }

        [Display(Name = "If you are due a refund, would you like:", ResourceType = typeof(Resource))]
        public string If_you_are_due_a_refund { get; set; }

        [Display(Name = "Direct deposit", ResourceType = typeof(Resource))]
        public string Direct_deposite { get; set; }

        [Display(Name = "To purchase U.S. Savings Bonds", ResourceType = typeof(Resource))]
        public string To_purchase_us_savings_bonds { get; set; }

        [Display(Name = "To split your refund between different accounts", ResourceType = typeof(Resource))]
        public string To_split_your_refund_between_diffrent { get; set; }

        [Display(Name = "If you have a balance due, would you like to make a payment directly from your bank account?", ResourceType = typeof(Resource))]
        public string If_you_have_a_balance_due { get; set; }

        [Display(Name = "Did you live in an area that was declared a Federal disaster area?", ResourceType = typeof(Resource))]
        public string Did_you_live_in_an_area_that { get; set; }

        [Display(Name = "If yes, where?", ResourceType = typeof(Resource))]
        public string If_yes_where { get; set; }

        [Display(Name = "Did you, or your spouse if filing jointly, receive a letter from the IRS?", ResourceType = typeof(Resource))]
        public string Did_you_or_your_spouse_if_filling_jointly { get; set; }

        [Display(Name = "Many free tax preparation sites operate by receiving grant money or other federal financial assistance. The data from the following questions may be used by this site to apply for these grants or to support continued receipt of financial funding . Your answer will be used only for statistical purposes. These questions are optional.", ResourceType = typeof(Resource))]
        public string rf6 { get; set; }

        [Display(Name = "Would you say you can carry on a conversation in English, both understanding & speaking?", ResourceType = typeof(Resource))]
        public string rf7 { get; set; }

        [Display(Name = "Very well", ResourceType = typeof(Resource))]
        public string rf8 { get; set; }

        [Display(Name = "Well", ResourceType = typeof(Resource))]
        public string rf9 { get; set; }

        [Display(Name = "Not well", ResourceType = typeof(Resource))]
        public string rf10 { get; set; }

        [Display(Name = "Not at all", ResourceType = typeof(Resource))]
        public string tg1 { get; set; }

        [Display(Name = "Prefer not to answer", ResourceType = typeof(Resource))]
        public string tg2 { get; set; }

        [Display(Name = "Would you say you can read a newspaper or book in English?", ResourceType = typeof(Resource))]
        public string tg3 { get; set; }

        [Display(Name = "Do you or any member of your household have a disability?", ResourceType = typeof(Resource))]
        public string tg4 { get; set; }

        [Display(Name = "Are you or your spouse a Veteran from the U.S. Armed Forces?", ResourceType = typeof(Resource))]
        public string tg5 { get; set; }

        [Display(Name = "Your race?", ResourceType = typeof(Resource))]
        public string tg6 { get; set; }

        [Display(Name = "American Indian or Alaska Native", ResourceType = typeof(Resource))]
        public string tg7 { get; set; }

        [Display(Name = "Asian", ResourceType = typeof(Resource))]
        public string tg8 { get; set; }

        [Display(Name = "Black or African American", ResourceType = typeof(Resource))]
        public string tg9 { get; set; }

        [Display(Name = "Native Hawaiian or other Pacific Islander", ResourceType = typeof(Resource))]
        public string tg10 { get; set; }

        [Display(Name = "White", ResourceType = typeof(Resource))]
        public string yh1 { get; set; }

        [Display(Name = "Your spouse’s race?", ResourceType = typeof(Resource))]
        public string yh2 { get; set; }

        [Display(Name = "American Indian or Alaska Native", ResourceType = typeof(Resource))]
        public string yh3 { get; set; }

        [Display(Name = "Native Hawaiian or other Pacific Islander", ResourceType = typeof(Resource))]
        public string yh4 { get; set; }

        [Display(Name = "No spouse", ResourceType = typeof(Resource))]
        public string yh5 { get; set; }

        [Display(Name = "Your ethnicity?", ResourceType = typeof(Resource))]
        public string yh6 { get; set; }

        [Display(Name = "Hispanic or Latino", ResourceType = typeof(Resource))]
        public string yh7 { get; set; }

        [Display(Name = "Not Hispanic or Latino", ResourceType = typeof(Resource))]
        public string yh8 { get; set; }

        [Display(Name = "Additional comments", ResourceType = typeof(Resource))]
        public string yh9 { get; set; }

        [Display(Name = "Privacy Act and Paperwork Reduction Act Notice", ResourceType = typeof(Resource))]
        public string yh10 { get; set; }

        [Display(Name = "The Privacy Act of 1974 requires that when we ask for information we tell you our legal right to ask for the information, why we are asking for it, and how it will be used. We must also tell you what could happen if we do not receive it, and whether your response is voluntary, required to obtain a benefit, or mandatory. Our legal right to ask for information is 5 U.S.C. 301. We are asking for this information to assist us in contacting you relative to your interest and/or participation in the IRS volunteer income tax preparation and outreach programs. The information you provide may be furnished to others who coordinate activities and staffing at volunteer return preparation sites or outreach activities. The information may also be used to establish effective controls, send correspondence and recognize volunteers. Your response is voluntary. However, if you do not provide the requested information, the IRS may not be able to use your assistance in these programs. The Paperwork Reduction Act requires that the IRS display an OMB control number on all public information requests. The OMB Control Number for this study is 154-1964. Also, if you have any comments regarding the time estimates associated with this study or suggestion on making this process simpler, please write to the Internal Revenue Service, Tax Products Coordinating Committee, SE:W:CAR:MP:T:T:SP, 1111 Constitution Ave. NW, Washington, DC 20224", ResourceType = typeof(Resource))]
        public string uj1 { get; set; }

        [Display(Name = "Catalog Number 52121E", ResourceType = typeof(Resource))]
        public string uj2 { get; set; }

        [Display(Name = "www.irs.gov", ResourceType = typeof(Resource))]
        public string uj3 { get; set; }

        [Display(Name = "Form 13614-C (Rev. 10-2020)", ResourceType = typeof(Resource))]
        public string uj4 { get; set; }

        [Display(Name = "15080 (EN-SP)", ResourceType = typeof(Resource))]
        public string uj5 { get; set; }

        [Display(Name = "(July 2020)", ResourceType = typeof(Resource))]
        public string uj6 { get; set; }

        [Display(Name = "Department of the Treasury - Internal Revenue Service", ResourceType = typeof(Resource))]
        public string uj7 { get; set; }

        [Display(Name = "Consent to Disclose Tax Return Information to VITA/TCE Tax Preparation Sites", ResourceType = typeof(Resource))]
        public string uj8 { get; set; }

        [Display(Name = "Federal Disclosure:", ResourceType = typeof(Resource))]
        public string uj9 { get; set; }

        [Display(Name = "Federal law requires this consent form be provided to you. Unless authorized by law, we cannot disclose your tax return information to third parties for purposes other than the preparation and filing of your tax return without your consent. If you consent to the disclosure of your tax return information, Federal law may not protect your tax return information from further use or distribution.", ResourceType = typeof(Resource))]
        public string uj10 { get; set; }

        [Display(Name = "You are not required to complete this form to engage our tax return preparation services. If we obtain your signature on this form by conditioning our tax return preparation services on your consent, your consent will not be valid. If you  agree to the disclosure of your tax return information, your consent is valid for the amount of time that you specify. If  you do not specify the duration of your consent, your consent is valid for one year from the date of signature.", ResourceType = typeof(Resource))]
        public string ik1 { get; set; }

        [Display(Name = "Terms:", ResourceType = typeof(Resource))]
        public string ik2 { get; set; }

        [Display(Name = "Global Carry Forward of data allows TaxSlayer LLC, the provider of the VITA/TCE tax software, to make your tax return information available to ANY volunteer site participating in the IRS's VITA/TCE program that you select to prepare a tax return in the next filing season. This means you will be able to visit any volunteer site using TaxSlayer next year and have your tax return populate with your current year data, regardless of where you filed your tax return this year. This consent is valid through November 12, 2022.", ResourceType = typeof(Resource))]
        public string ik3 { get; set; }

        [Display(Name = "The tax return information that will be disclosed includes, but is not limited to, demographic, financial and other personally identifiable information, about you, your tax return and your sources of income, which was input into the tax preparation software for the purpose of preparing your tax return. This information includes your name, address, date of birth, phone number, SSN, filing status, occupation, employer's name and address, and the amounts and sources of income, deductions and credits that were claimed on, or contained within, your tax return. The tax return information that will be disclosed also includes the name, SSN, date of birth, and relationship of any dependents that were claimed on your tax return.", ResourceType = typeof(Resource))]
        public string ik4 { get; set; }

        [Display(Name = "You do not need to provide consent for the VITA/TCE partner preparing your tax return this year. Global Carry Forward will assist you only if you visit a different VITA or TCE partner next year that uses TaxSlayer.", ResourceType = typeof(Resource))]
        public string ik5 { get; set; }

        [Display(Name = "Limitation on the Duration of Consent: I/we, the taxpayer, do not wish to limit the duration of the consent of the disclosure of tax return information to a date earlier than presented above (November 12, 2022). If I/we wish to limit the duration of the consent of the disclosure to an earlier date, I/we will deny consent.", ResourceType = typeof(Resource))]
        public string ik6 { get; set; }

        [Display(Name = "Limitation on the Scope of Disclosure: I/we, the taxpayer, do not wish to limit the scope of the disclosure of tax return information further than presented above. If I/we wish to limit the scope of the disclosure of tax return  information further than presented above, I/we will deny consent.", ResourceType = typeof(Resource))]
        public string ik7 { get; set; }

        [Display(Name = "I/we, the taxpayer, have read the above information.", ResourceType = typeof(Resource))]
        public string I_or_we_the_taxpayers_have_read_the { get; set; }

        [Display(Name = "Consent:", ResourceType = typeof(Resource))]
        public string Consent { get; set; }

        [Display(Name = "I/we hereby consent to the disclosure of tax return information described in the Global Carry Forward terms above and allow the tax return preparer to enter a PIN in the tax preparation software on my behalf to verify that I/we  consent to the terms of this disclosure.", ResourceType = typeof(Resource))]
        public string I_here_by_consent_to_the_disclosure { get; set; }

        [Display(Name = "Primary taxpayer printed name and signature", ResourceType = typeof(Resource))]
        public string Primary_signature { get; set; }

        [Display(Name = "Date", ResourceType = typeof(Resource))]
        public string Date { get; set; }

        [Display(Name = "Secondary taxpayer printed name and signature", ResourceType = typeof(Resource))]
        public string Secondry_signatue { get; set; }

        [Display(Name = "If you believe your tax return information has been disclosed or used improperly in a manner unauthorized by law or without your permission, you may contact the Treasury Inspector General for Tax Administration (TIGTA) by telephone at 1-800-366-4484, or by e-mail at complaints@tigta.treas.gov.", ResourceType = typeof(Resource))]
        public string If_you_belive_your_tax_return_information { get; set; }

        [Display(Name = "Catalog Number 71414A", ResourceType = typeof(Resource))]
        public string ol5 { get; set; }

        [Display(Name = "15080 (EN-SP)", ResourceType = typeof(Resource))]
        public string ol7 { get; set; }

        [Display(Name = "(Rev. 7-2020)", ResourceType = typeof(Resource))]
        public string ol8 { get; set; }

        [Display(Name = "Additional Information", ResourceType = typeof(Resource))]
        public string AdditionalInformation { get; set; }

        [Display(Name = "Please Complete the Form Below", ResourceType = typeof(Resource))]
        public string completeformbelow { get; set; }

        [Display(Name = "Social Security Number", ResourceType = typeof(Resource))]
        public string Social_security_number { get; set; }

        [Display(Name = "Primary taxpayer printed name", ResourceType = typeof(Resource))]
        public string Primary_taxpayer_printed_name { get; set; }

        [Display(Name = "Secondary taxpayer printed name", ResourceType = typeof(Resource))]
        public string Secondry_taxpayer_printed_name { get; set; }

        [Display(Name = "I authorize my Tax Preparer to enter the five number PIN I have choosen below.", ResourceType = typeof(Resource))]
        public string I_authorize_my_tax_prepare_to_enter_the { get; set; }

        [Display(Name = "Upload your Documents here:", ResourceType = typeof(Resource))]
        public string Upload_your_documents_here { get; set; }

        [Display(Name = "Choose your File", ResourceType = typeof(Resource))]
        public string Choose_your_file { get; set; }

        [Display(Name = "Additional Doc Files", ResourceType = typeof(Resource))]
        public string Additional_doc_files { get; set; }

        [Display(Name = "Uploaded Files:", ResourceType = typeof(Resource))]
        public string Uploaded_files { get; set; }

        [Display(Name = "Submit", ResourceType = typeof(Resource))]
        public string Submit { get; set; }
    }
}