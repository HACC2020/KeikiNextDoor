using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OhanaSupport.Migrations
{
    public partial class SeedDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Links",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "Origin", "Published", "Type", "UpdatedAt", "Url" },
                values: new object[,]
                {
                    { new Guid("6058a82e-c1dc-414c-90c3-200a97944b8d"), new DateTime(2020, 11, 11, 3, 38, 9, 386, DateTimeKind.Local).AddTicks(6181), "Talking to children about the use of masks and talking to children about covid 19 ", "Why are people wearing masks? Why are people covering their faces?", "zerotothree", null, 1, null, "https://www.zerotothree.org/resources/3211-why-are-people-wearing-masks-why-are-people-covering-their-faces" },
                    { new Guid("a4efa4f5-19f6-43da-8710-34e12656dd36"), new DateTime(2020, 11, 11, 3, 38, 9, 391, DateTimeKind.Local).AddTicks(7576), "Routines for the very young child with love and learning.", "Creating Routines for Love and Learning", "zerotothree", new DateTime(2010, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, "https://www.zerotothree.org/resources/223-creating-routines-for-love-and-learning" },
                    { new Guid("10ef6655-5cfb-40d3-b4ea-138fdd9ffd77"), new DateTime(2020, 11, 11, 3, 38, 9, 391, DateTimeKind.Local).AddTicks(7581), "How to plan and make home routines.", "How to Make a New Home Routine", "PBS", new DateTime(2020, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, "https://www.pbs.org/parents/thrive/schools-closed-how-to-make-a-new-home-routine" },
                    { new Guid("35af062d-cdee-4bf2-8d10-3b2a4d5d35a4"), new DateTime(2020, 11, 11, 3, 38, 9, 391, DateTimeKind.Local).AddTicks(7610), "Advice on how to make a family routine and why they work.", "Family routines: how and why they work", "Raising Children", new DateTime(2017, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, "https://raisingchildren.net.au/grown-ups/family-life/routines-rituals-relationships/family-routines" },
                    { new Guid("39e90802-df2e-4f05-8bf0-ec3cda2782a5"), new DateTime(2020, 11, 11, 3, 38, 9, 391, DateTimeKind.Local).AddTicks(7616), "An article on the possible outcomes of sending your child back to school.", "Sending Your Child Back to School with COVID-19", "CNN", new DateTime(2020, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, "https://www.cnn.com/2020/05/16/health/preschool-childcare-reopen-parenting-coronavirus-wellness/index.html" },
                    { new Guid("5ef9d6b1-47bd-4887-bfd2-e130f3f29cdc"), new DateTime(2020, 11, 11, 3, 38, 9, 391, DateTimeKind.Local).AddTicks(7619), "Over 30 Virtual Field Trips with Links", "Virtual Field Trips", "[Unknown]", null, 2, null, "https://docs.google.com/document/d/1SvIdgTx9djKO6SjyvPDsoGlkgE3iExmi3qh2KRRku_w/preview?fbclid=IwAR22dnud3aOY2r9HW2yPyL_QXopce2D1hFf5ozlolgdW279Yo6q7l8Zm1tw " },
                    { new Guid("1a627430-6cef-4a81-88f2-79ee9adfcb12"), new DateTime(2020, 11, 11, 3, 38, 9, 391, DateTimeKind.Local).AddTicks(7621), "A description of parents rights to paid sick-leave and time-off during COVID-19", "Know your rights: Paid sick days & paid leave during COVID-19", "Hawaii Children's Action Network", null, 1, null, "https://www.hawaii-can.org/rights_paid_leave_covid19" },
                    { new Guid("fc13c569-da0c-4f19-bba0-f1491850d3d4"), new DateTime(2020, 11, 11, 3, 38, 9, 391, DateTimeKind.Local).AddTicks(7624), "A page with links to help with learning at home.", "Wakelet: Learn At Home", "Wakelet", null, 1, null, "https://wakelet.com/wake/c815de12-b0be-4701-a25b-afe850025f2e" },
                    { new Guid("ea94b18d-7c05-4e13-93ab-ab448452991e"), new DateTime(2020, 11, 11, 3, 38, 9, 391, DateTimeKind.Local).AddTicks(7629), "An article about spatial reasoning by the Development and Research in Early Math Education.", "Spatial Reasoning: Why Math Talk is About More Than Numbers", "DREME", new DateTime(2017, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, "https://dreme.stanford.edu/news/spatial-reasoning-why-math-talk-about-more-numbers " },
                    { new Guid("a2bdc0c4-fea7-4e66-90dc-a5d068c854b9"), new DateTime(2020, 11, 11, 3, 38, 9, 391, DateTimeKind.Local).AddTicks(7571), "The homepage for Maui Family Support Services, Inc.", "Maui Family Support Services", "MFSS", null, 1, null, "https://mfss.org/" },
                    { new Guid("8356106d-f708-48fb-9499-cf0dd3b677c5"), new DateTime(2020, 11, 11, 3, 38, 9, 391, DateTimeKind.Local).AddTicks(7633), "Ways to make camps safe for kids and staff", "Suggestions for Youth and Summer Camps", "CDC", new DateTime(2020, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, "https://www.cdc.gov/coronavirus/2019-ncov/community/schools-childcare/summer-camps.html" },
                    { new Guid("a8369011-960d-41e1-ab81-111106be561e"), new DateTime(2020, 11, 11, 3, 38, 9, 391, DateTimeKind.Local).AddTicks(7640), "Activities by the University of Hawaii at Manoa's Learnign to Grow page.", "Learning to Grow Activities", "University of Hawaii Manoa", null, 1, null, "http://learningtogrowhawaii.org/activity/" },
                    { new Guid("4eb39313-02a6-4139-93e5-b39609fc4167"), new DateTime(2020, 11, 11, 3, 38, 9, 391, DateTimeKind.Local).AddTicks(7645), "Supporting foundational math skills from the Development and Research in Early Math Education.", "Executive Functions: Supporting Foundational Skills for Early Math Learning", "DREME", new DateTime(2018, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, "https://dreme.stanford.edu/news/executive-functions-supporting-foundational-skills-early-math-learning" },
                    { new Guid("9a848840-6c03-4df8-bfb4-1122c8400c06"), new DateTime(2020, 11, 11, 3, 38, 9, 391, DateTimeKind.Local).AddTicks(7647), "Resources to get children connected to the care they need as the parents return to work.", "Finding Care for Your Child", "State of Hawaii Executive Office of Early Learning", null, 1, null, "https://sites.google.com/eoel.hawaii.gov/covid-19/home/families-resources/find-care?authuser=0" },
                    { new Guid("4190e202-1477-40a2-935a-d85ba55d713a"), new DateTime(2020, 11, 11, 3, 38, 9, 391, DateTimeKind.Local).AddTicks(7650), "A page with many links for at-home resources for families by the Executive Office on Early Learning.", "At-Home Resources for Families from Executive Office on Early Learning", "EOEL", null, 1, null, "https://sites.google.com/eoel.hawaii.gov/covid-19/home/families-resources/at-home-resources-for-families?authuser=0" },
                    { new Guid("96c7a4ef-43d0-4d89-a3c9-5a3974f36533"), new DateTime(2020, 11, 11, 3, 38, 9, 391, DateTimeKind.Local).AddTicks(7655), "A page that tells you about how far your child should be in there development milestones", "CDC's Development Milestones for Infants", "CDC", new DateTime(2018, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, "https://www.cdc.gov/ncbddd/actearly/milestones/index.html" },
                    { new Guid("0ce04084-dcb1-4250-8d7c-a73385cbb76d"), new DateTime(2020, 11, 11, 3, 38, 9, 391, DateTimeKind.Local).AddTicks(7659), "An article on what coding is and how can you get children started with coding.", "Coding with Children", "NAEYC", new DateTime(2017, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, "https://www.naeyc.org/resources/pubs/tyc/feb2017/creating-coding-stories-and-games" },
                    { new Guid("fe7a07aa-7456-481a-971d-fcc0a65fb34e"), new DateTime(2020, 11, 11, 3, 38, 9, 391, DateTimeKind.Local).AddTicks(7662), "The museums at home page for Children's Museum", "Children's Museum Pittsburgh: Museum at Home Activities", "Children's Museum", null, 1, null, "https://pittsburghkids.org/museumathome?fbclid=IwAR3yseklPsMAcnjBxaoU31-25ZBa1iefBJq49SY5JahFrenX00N6JPfgvAY" },
                    { new Guid("1ccf53a1-ceb8-43cd-beb1-27efbdc8f25e"), new DateTime(2020, 11, 11, 3, 38, 9, 391, DateTimeKind.Local).AddTicks(7664), "Special Olympics Hawaii Fit Programs At Home.", "Stay Fit with SOHI", "Special Olympics Hawaii", null, 1, null, "http://sohawaii.org/stay-fit-with-sohi/" },
                    { new Guid("3334b097-20a9-453f-9ef7-919432abeb64"), new DateTime(2020, 11, 11, 3, 38, 9, 391, DateTimeKind.Local).AddTicks(7637), "The importance of numbers and how to support number learning by the Development and Research in Early Math Education.", "Making the Most of Talk About Numbers", "DREME", new DateTime(2017, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, "https://dreme.stanford.edu/news/making-most-talk-about-numbers" },
                    { new Guid("62bcbadc-1b42-437f-9a13-3f52d76123aa"), new DateTime(2020, 11, 11, 3, 38, 9, 391, DateTimeKind.Local).AddTicks(7568), "Information on applying for the Pauahi Keiki Scholars (PKS) scholarship.", "Puahi Keiki Scholars", "Kamehameha Schools", null, 1, null, "https://www.ksbe.edu/apply/financial_aid/preschool/pauahi_keiki_scholars/" },
                    { new Guid("0eba1889-edc2-48c1-a5eb-45fc773e192c"), new DateTime(2020, 11, 11, 3, 38, 9, 391, DateTimeKind.Local).AddTicks(7668), "UCLAMP homepage that includes how to stay engaged with math at home.", "UCLAMP: Math at Home", "Special Olympics Hawaii", null, 1, null, "https://sites.google.com/view/uclamp-math-at-home/home?authuser=0" },
                    { new Guid("578a9540-9f86-48f7-8dea-ab1db8033422"), new DateTime(2020, 11, 11, 3, 38, 9, 391, DateTimeKind.Local).AddTicks(7560), "Resources for parents or caregivers that need information about transitioning in the re-opening phase for the state", "Family Resources for Reopening Phase", "State of Hawaii Executive Office on Early Learning", null, 1, null, "https://sites.google.com/eoel.hawaii.gov/covid-19/home/families-resources/family-resources-for-reopening-phase?authuser=0" },
                    { new Guid("500dc1df-9607-4e2a-8a23-e138692382c5"), new DateTime(2020, 11, 11, 3, 38, 9, 391, DateTimeKind.Local).AddTicks(7417), "A checklist or guideline to follow for childcare facilities to reopen or continue care.", "Guidelines for Child Care Facilities to Reopen or Continue Care", "Human Services", new DateTime(2020, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, "https://humanservices.hawaii.gov/wp-content/uploads/2020/05/Guidelines-for-Child-Care-Facilities-2020-05-19-final.pdf" },
                    { new Guid("89db9df9-b7aa-44da-a446-a240e64d4b5c"), new DateTime(2020, 11, 11, 3, 38, 9, 391, DateTimeKind.Local).AddTicks(7485), "An article avocating the pros and cons of sending your child back to daycare.", "Is it time to send your kid back to daycare", "Fatherly", new DateTime(2020, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, "https://www.fatherly.com/health-science/daycare-coronavirus-safety-health/" },
                    { new Guid("c2b77138-6689-49cc-9d79-39389c20cee2"), new DateTime(2020, 11, 11, 3, 38, 9, 391, DateTimeKind.Local).AddTicks(7490), "Covid 19 recources for families with young kids that need help with child care, daycare, and as well as donations. For Child providers it is a place to bring recources together for providers ", "COVID19 Resources and Info", "Executive Office on Early Learning, State of Hawaii", null, 1, null, "https://sites.google.com/eoel.hawaii.gov/covid-19/home?authuser=0" },
                    { new Guid("4267f54f-70c8-4fa6-9f79-e6c7ffd35ef7"), new DateTime(2020, 11, 11, 3, 38, 9, 391, DateTimeKind.Local).AddTicks(7493), "The CDC main website explaining the Corona Virus", "Learn more about the novel coronavirus from the CDC", "CDC", null, 1, null, " https://www.cdc.gov/coronavirus/2019-nCoV/index.html" },
                    { new Guid("d23dba1f-e4ff-4392-aa3b-3a0d2a163cf5"), new DateTime(2020, 11, 11, 3, 38, 9, 391, DateTimeKind.Local).AddTicks(7501), "Advice for how to plan daily schedules for children and keep them engaged at home.", "Use This Daily Schedule to Keep Children at Home Engaged", "Teachstone", new DateTime(2020, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, "https://info.teachstone.com/blog/keep-children-engaged-while-at-home-with-a-daily-schedule?utm_campaign=COVID-19&utm_source=hs_email&utm_medium=email&utm_content=85052481&_hsenc=p2ANqtz-_UYrZW7EKyGon7LxbuMktCDHvUCQI0BKU_wHSLtS-s2lB-Y33_R1oXSAma5dH3GT09NfdpeBBLsL-AoZ56eBkOBQ7zqg&_hsmi=85052481" },
                    { new Guid("43dfcbd5-f4ac-44bc-a801-660061e53125"), new DateTime(2020, 11, 11, 3, 38, 9, 391, DateTimeKind.Local).AddTicks(7565), "A survey to determine if the parents are eligible to receive child care assistance", "Eligibility Screening for Child Care Assistance", "Quality Care for Hawaiian Keiki", new DateTime(2019, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, "https://www.surveymonkey.com/r/QCHK2016" },
                    { new Guid("b82d52f2-4512-4ff0-a8e5-2ddcfe3bd2d6"), new DateTime(2020, 11, 11, 3, 38, 9, 391, DateTimeKind.Local).AddTicks(7511), "How to help children develop handwashing skills", "Helping Children Develop handwashing skills", "CDC", new DateTime(2020, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, "https://www.cdc.gov/handwashing/handwashing-family.html" },
                    { new Guid("62673a98-212a-4086-81b8-c81c6d3d4dc1"), new DateTime(2020, 11, 11, 3, 38, 9, 391, DateTimeKind.Local).AddTicks(7516), "Advice for how to plan daily schedules for children and keep them engaged at home.", "A Thriving Lahui", "Teachstone", new DateTime(2020, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, "https://docs.google.com/document/d/1u1QkZ0ZMUTFc6tfyzyJTZYoUixCC8H9p5rcQsKCmdHk/edit" },
                    { new Guid("7f411aa8-26af-48f8-8b69-5e7025b4a935"), new DateTime(2020, 11, 11, 3, 38, 9, 391, DateTimeKind.Local).AddTicks(7521), "Advice on what to do and know before sending your child back to childcare.", "What Comes Next: Back to Child Care Following Shelter-in-Place", "zerotothree", new DateTime(2020, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, "https://www.zerotothree.org/resources/3413-what-comes-next-back-to-child-care-following-shelter-in-place" },
                    { new Guid("9b15c06c-b07b-47c6-a95c-af95825180b3"), new DateTime(2020, 11, 11, 3, 38, 9, 391, DateTimeKind.Local).AddTicks(7507), "Playing safely with children at home", "At Home Activities for Infants and Toddlers", "zerotothree", new DateTime(2020, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, " https://www.zerotothree.org/resources/3264-at-home-activity-guide" },
                    { new Guid("145da347-783c-4fec-b163-ec4c76b306c2"), new DateTime(2020, 11, 11, 3, 38, 9, 391, DateTimeKind.Local).AddTicks(7527), "Emergency proclamations for the county of Hawaii on hawaiicounty.gov", "County of Hawaii Emergency Proclamations", "Hawaii County", null, 1, null, "https://www.hawaiicounty.gov/departments/civil-defense/active-emergency-proclamations" },
                    { new Guid("5dc91c8c-a8eb-4d04-8ca0-3de007d17cdc"), new DateTime(2020, 11, 11, 3, 38, 9, 391, DateTimeKind.Local).AddTicks(7524), "Emergency proclamations for the state of Hawaii on governor.hawaii.gov", "State of Hawaii Emergency Proclamations", "State of Hawaii", null, 1, null, "https://governor.hawaii.gov/emergency-proclamations/" },
                    { new Guid("b59efa1b-9b14-4313-bf8a-18088bc3ad8c"), new DateTime(2020, 11, 11, 3, 38, 9, 391, DateTimeKind.Local).AddTicks(7552), "Information for Child Care Assistance and Early Education Scholarships", "Subsidy And Scholarship Information", "State of Hawaii Executive Office on Early Learning", null, 1, null, "https://sites.google.com/eoel.hawaii.gov/covid-19/home/families-resources/subsidy-and-scholarship-information?authuser=0" },
                    { new Guid("1921a6cb-7ef9-47ba-ba7c-0bc7f47d028c"), new DateTime(2020, 11, 11, 3, 38, 9, 391, DateTimeKind.Local).AddTicks(7549), "The homepage for Hawaii's portal in response to Covid-19.", "Hawaii Department of Health Covid 19", "State of Hawaii", new DateTime(2020, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, "https://hawaiicovid19.com/" },
                    { new Guid("305ccacd-ed90-481e-8f8e-b28ce910cb97"), new DateTime(2020, 11, 11, 3, 38, 9, 391, DateTimeKind.Local).AddTicks(7544), "Schools and childcare info from the CDC in regards to COVID-19.", "Childcare Decision Tools", "CDC", new DateTime(2020, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, "https://www.cdc.gov/coronavirus/2019-ncov/community/schools-childcare/index.html?CDC_AA_refVal=https%3A%2F%2Fwww.cdc.gov%2Fcoronavirus%2F2019-ncov%2Fcommunity%2Fschools-childcare%2Fchild-care-decision-tool.html" },
                    { new Guid("8feb1de4-7011-4939-8ea1-25927280d0dd"), new DateTime(2020, 11, 11, 3, 38, 9, 391, DateTimeKind.Local).AddTicks(7557), "Checklist for teachers and parents in regards to going back to school during the pandemic.", "Back to School Planning: Checklists to Guide Parents, Guardians, and Caregivers", "CDC", new DateTime(2020, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, "https://www.cdc.gov/coronavirus/2019-ncov/community/schools-childcare/parent-checklist.html?CDC_AA_refVal=https%3A%2F%2Fwww.cdc.gov%2Fcoronavirus%2F2019-ncov%2Fcommunity%2Fschools-childcare%2Fchecklist.html" },
                    { new Guid("1e792fe6-ab89-418e-8456-cfa05a433d25"), new DateTime(2020, 11, 11, 3, 38, 9, 391, DateTimeKind.Local).AddTicks(7535), "Emergency Declarations for the County of Maui.", "County of Maui Emergency Declarations", "County of Maui", null, 1, null, "https://www.mauicounty.gov/2006/Declarations" },
                    { new Guid("0b7ad369-255a-418e-85f0-ea9efcdbb04d"), new DateTime(2020, 11, 11, 3, 38, 9, 391, DateTimeKind.Local).AddTicks(7532), "Emergency Proclamations for the County of Kaua`i.", "County of Kaua`i Emergency Proclamations", "County of Kaua`i", null, 1, null, "https://www.kauai.gov/Government/Departments-Agencies/Emergency-Management-Agency-formerly-Civil-Defense/Emergency-Proclamations" },
                    { new Guid("85602a47-13d3-4bc0-874e-3dcb5066a4b5"), new DateTime(2020, 11, 11, 3, 38, 9, 391, DateTimeKind.Local).AddTicks(7529), "The proclamations, orders, and rules in response to Covid 19 for the City and County of Honolulu.", "City and County of Honolulu Covid 19 Response", "City and County of Honolulu", null, 1, null, "https://www.honolulu.gov/mayor/proclamations-orders-and-rules.html" }
                });

            migrationBuilder.InsertData(
                table: "Links",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "Origin", "Published", "Type", "UpdatedAt", "Url" },
                values: new object[] { new Guid("595ca34e-fa75-4c0e-b730-62c19cd36fea"), new DateTime(2020, 11, 11, 3, 38, 9, 391, DateTimeKind.Local).AddTicks(7540), "The surveillance and control goals and activities from the CDC to support response to COVID-19.", "CDC Activities and Initiatives Supporting the COVID-19 Response and the President's Plan for Opening America Up Again", "CDC", new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, "https://www.cdc.gov/coronavirus/2019-ncov/downloads/php/CDC-Activities-Initiatives-for-COVID-19-Response.pdf" });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "Text" },
                values: new object[,]
                {
                    { new Guid("df91bd45-cc8c-458f-9079-b20b65ec5caf"), "Guideline" },
                    { new Guid("45e34501-421a-4ba3-85d2-b07eb71c3f5c"), "Health" },
                    { new Guid("b7cc1c6f-ca92-4c00-b899-cdc0aba0590b"), "Department" },
                    { new Guid("244c117c-e184-473b-9131-02fc45d1b4e5"), "Special" },
                    { new Guid("f0d0e2f7-f03c-46df-8a6a-4e94cf4dce55"), "Pre-K" },
                    { new Guid("bd2bbdb1-379d-4fdc-b7bb-27b2a1770c4c"), "Schedule" },
                    { new Guid("7319b1f7-e0ef-49b7-9cc2-b73c3e79f5eb"), "Year" },
                    { new Guid("63bd4a10-d00f-4d3e-a913-c2b1eb00ca1c"), "Old" },
                    { new Guid("09c743bf-7461-4f43-a671-9966d03b9d0c"), "Tips" },
                    { new Guid("40f84a57-8260-47c3-8e53-55f5c67719c6"), "Corona" },
                    { new Guid("381184be-55af-4f55-9fd5-94a5c5864582"), "Government" },
                    { new Guid("344c0405-f0b9-408e-ae56-063bfa06d705"), "Federal" },
                    { new Guid("a6ce6fc1-ebf4-4286-80da-fccf5aa60266"), "Lahui" },
                    { new Guid("a7f9abec-e209-4a5c-99e3-bdb3a679a2f7"), "Routine" },
                    { new Guid("9e7303bc-730a-4d5c-a110-57029ffd7ff4"), "Schedule" },
                    { new Guid("6df13233-ad61-45ff-942b-1857da99c0f1"), "Skills" },
                    { new Guid("233a88ca-3452-4b7b-89d3-efb6fe405316"), "Advice" },
                    { new Guid("fcc2ef68-57e6-4114-ad5f-cf3fb81e89a0"), "Olympic" },
                    { new Guid("3a06d804-0635-4cd0-81ca-4dbcab0e5c40"), "State" },
                    { new Guid("021fcffe-e6d7-4f68-810b-2330116331b3"), "Fit" },
                    { new Guid("8bb5da12-bd2f-4357-bfd3-7628ff23ac81"), "Virtual" },
                    { new Guid("5391b3cc-31be-4ed7-906b-969a08e11ac3"), "Grow" },
                    { new Guid("55e88610-b070-42aa-8c99-533b2b881b05"), "Coding" },
                    { new Guid("958fa84a-469b-42c3-a6f2-9ee4276b2e40"), "Education" },
                    { new Guid("ac00b15c-a093-483a-bc71-76f18843c2dc"), "Milestone" },
                    { new Guid("233091f1-0bc4-402f-aca0-a64e057322f8"), "DREME" },
                    { new Guid("9be2b66e-aacd-4110-b937-87e7de68aae9"), "Museum" },
                    { new Guid("3169bb2b-b752-4a1a-bdcb-294c8a080979"), "Foundation" },
                    { new Guid("8606f298-1d23-4001-9115-cb487dd96e77"), "Field" },
                    { new Guid("d41b6b30-ecd0-4a5d-bd45-4ecabd20011b"), "Website" },
                    { new Guid("9cfce7ee-c57a-476c-86fd-fd87a13dd573"), "Trip" },
                    { new Guid("6dc7eabd-f824-457f-a738-9bac58b5604b"), "Teacher" },
                    { new Guid("a39d1527-8d4f-4ff8-bcbf-c3458de5588e"), "Checklist" },
                    { new Guid("cf0def79-5b99-4754-a775-b76f14f3bbe4"), "Culture" },
                    { new Guid("b22ec78a-cfb1-4278-905d-857b79f7fa0b"), "Handwashing" },
                    { new Guid("ac585b09-b9a3-438f-8f8e-73b9f16fe597"), "Update" },
                    { new Guid("e1683932-78a2-4ded-a23b-7729573aceca"), "Wakelet" },
                    { new Guid("12abccf4-937a-48b4-8cfc-eacdc2eb4358"), "Reasoning" },
                    { new Guid("aba5e721-d45c-4da5-b9f7-6dab5bab3298"), "Spatial" },
                    { new Guid("0e3ce281-5d28-40f5-b34e-43ff5dc07b16"), "Talk" },
                    { new Guid("e3df4bb9-eda1-4896-a72b-1ecb66b55779"), "Number" }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "Text" },
                values: new object[,]
                {
                    { new Guid("40b4e33f-1859-45fe-b6c7-7ee7eac6e337"), "Page" },
                    { new Guid("bc289b4d-20e1-4696-a55f-ac9023161b31"), "Math" },
                    { new Guid("f8a509cd-c12e-4122-ba76-1735d36facee"), "Caregiver" },
                    { new Guid("b659c2e0-f7e9-4258-a628-1e108831ddf0"), "Learning" },
                    { new Guid("ecf04aee-4f83-4631-998d-f398684a1824"), "Support" },
                    { new Guid("dc97a1f5-a068-4ea9-8513-84564acac4c1"), "Service" },
                    { new Guid("7a59d506-1192-47b3-a46d-6ec3a7f88664"), "Survey" },
                    { new Guid("cc857f6e-0f23-481a-8a21-19164e6414f1"), "Covid-19" },
                    { new Guid("9507c750-c643-47a7-90d3-46633c16c237"), "Eligibility" },
                    { new Guid("96bd77d3-3448-4fb8-88ff-80eed4e40737"), "Finance" },
                    { new Guid("19ccee14-002c-4bd0-a205-caa0c6acbe36"), "Aid" },
                    { new Guid("aacd600b-0eeb-4a52-b147-0f209549885f"), "Children" },
                    { new Guid("e9c19fff-b42b-49d1-8309-02ae412a60de"), "Keiki" },
                    { new Guid("48d069a2-9c39-4665-9485-22e4b56a7972"), "Pauahi" },
                    { new Guid("d416b04b-83b2-4f36-83bf-5b7fa817ee2c"), "Childcare" },
                    { new Guid("890985c5-b423-4fd4-bf40-91aa9bd2e5dc"), "Hawaiian" },
                    { new Guid("2d6c9fcb-a933-4912-a16c-4ad290777cb8"), "Subsidy" },
                    { new Guid("3d5838f2-4fff-4350-8de1-b6041ef68c9a"), "Scholarship" },
                    { new Guid("9cb56da2-a1a1-4f5a-bf76-5392d0a9b049"), "Resource" },
                    { new Guid("545a3223-1a97-43a2-ae74-60ff4dd2b7ec"), "Family" },
                    { new Guid("37b9e987-6a33-4514-a6d2-835903743369"), "Homepage" },
                    { new Guid("a8fd4501-4100-497b-8a17-8ddba4fd7886"), "EOEL" },
                    { new Guid("cbbc812e-3cab-42b9-aeca-f91cf21194c1"), "COVID" },
                    { new Guid("dc31bb70-1d06-4b28-9ba8-308a56ee9209"), "Maui" },
                    { new Guid("8debb346-fef6-44d3-baa8-37a0a12291a0"), "Parenting" },
                    { new Guid("b7bb539f-fa0e-4234-8f67-32a03b43e5f7"), "Transitioning" },
                    { new Guid("e9052ff3-f1fa-4792-ab3f-5a25b3686031"), "Proclamation" },
                    { new Guid("90e3d0f5-0487-467d-aee2-478378bff623"), "Early" },
                    { new Guid("87c3dfd2-eb9c-474c-bc20-d2586eff3fe2"), "Activities" },
                    { new Guid("cd0ada9b-9c35-45ed-b7fc-14079c01ffa7"), "Babies" },
                    { new Guid("8da99e93-ba60-40de-89f0-9032e0a5631b"), "Parent" },
                    { new Guid("4e4e0759-c9b0-47e7-9782-99a8e1cd601e"), "Toddler" },
                    { new Guid("b5afce52-fa3f-4edd-825f-ed59412143cf"), "Infant" },
                    { new Guid("a69946bc-acb4-4f7d-9eb0-7ed4f0ebac40"), "CDC" },
                    { new Guid("9a608f65-9834-47d9-85ce-2818907b0a3b"), "Home" },
                    { new Guid("cfba8acf-e9fb-4a5b-aaff-383636379268"), "Tool" },
                    { new Guid("3c85333d-03ce-4eea-b8f1-273a24cad04b"), "Care" },
                    { new Guid("639f0d3d-61b8-4d41-95e2-c948ce30171d"), "Camp" },
                    { new Guid("28c18b22-4699-4df3-8ac5-b76b13f3cd1b"), "Response" },
                    { new Guid("a48f9a90-f6a0-4f83-9750-b1ab9540a901"), "Coronavirus" },
                    { new Guid("382167e3-7ce7-4422-8c80-e4b2c18934c0"), "Kauai" },
                    { new Guid("a01dd380-0986-4b18-8e90-523f64fe815b"), "County" }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "Text" },
                values: new object[,]
                {
                    { new Guid("4acaf4bd-8b6c-4f99-aa82-9baaa28a0740"), "Honolulu" },
                    { new Guid("13c0cc5f-ad64-40bc-90b7-502e92e3d5c0"), "Hawaii" },
                    { new Guid("61d18801-8587-4763-862d-1dc0c69d831a"), "Employment" },
                    { new Guid("23e31995-07e9-4ef1-a79c-297d29e5c8dd"), "Masks" },
                    { new Guid("2a8f120d-fb1c-4cf8-8f2b-65179bfe59fc"), "Article" },
                    { new Guid("62025c26-33c8-47b1-919c-acb4191e3280"), "School" }
                });

            migrationBuilder.InsertData(
                table: "LinkTags",
                columns: new[] { "LinkId", "TagId" },
                values: new object[,]
                {
                    { new Guid("6058a82e-c1dc-414c-90c3-200a97944b8d"), new Guid("cbbc812e-3cab-42b9-aeca-f91cf21194c1") },
                    { new Guid("0eba1889-edc2-48c1-a5eb-45fc773e192c"), new Guid("9a608f65-9834-47d9-85ce-2818907b0a3b") },
                    { new Guid("595ca34e-fa75-4c0e-b730-62c19cd36fea"), new Guid("a69946bc-acb4-4f7d-9eb0-7ed4f0ebac40") },
                    { new Guid("305ccacd-ed90-481e-8f8e-b28ce910cb97"), new Guid("a69946bc-acb4-4f7d-9eb0-7ed4f0ebac40") },
                    { new Guid("8356106d-f708-48fb-9499-cf0dd3b677c5"), new Guid("a69946bc-acb4-4f7d-9eb0-7ed4f0ebac40") },
                    { new Guid("a8369011-960d-41e1-ab81-111106be561e"), new Guid("b5afce52-fa3f-4edd-825f-ed59412143cf") },
                    { new Guid("a8369011-960d-41e1-ab81-111106be561e"), new Guid("4e4e0759-c9b0-47e7-9782-99a8e1cd601e") },
                    { new Guid("9b15c06c-b07b-47c6-a95c-af95825180b3"), new Guid("8da99e93-ba60-40de-89f0-9032e0a5631b") },
                    { new Guid("8feb1de4-7011-4939-8ea1-25927280d0dd"), new Guid("8da99e93-ba60-40de-89f0-9032e0a5631b") },
                    { new Guid("a4efa4f5-19f6-43da-8710-34e12656dd36"), new Guid("8da99e93-ba60-40de-89f0-9032e0a5631b") },
                    { new Guid("a4efa4f5-19f6-43da-8710-34e12656dd36"), new Guid("cd0ada9b-9c35-45ed-b7fc-14079c01ffa7") },
                    { new Guid("9b15c06c-b07b-47c6-a95c-af95825180b3"), new Guid("87c3dfd2-eb9c-474c-bc20-d2586eff3fe2") },
                    { new Guid("595ca34e-fa75-4c0e-b730-62c19cd36fea"), new Guid("87c3dfd2-eb9c-474c-bc20-d2586eff3fe2") },
                    { new Guid("fe7a07aa-7456-481a-971d-fcc0a65fb34e"), new Guid("9a608f65-9834-47d9-85ce-2818907b0a3b") },
                    { new Guid("a8369011-960d-41e1-ab81-111106be561e"), new Guid("87c3dfd2-eb9c-474c-bc20-d2586eff3fe2") },
                    { new Guid("0eba1889-edc2-48c1-a5eb-45fc773e192c"), new Guid("87c3dfd2-eb9c-474c-bc20-d2586eff3fe2") },
                    { new Guid("fc13c569-da0c-4f19-bba0-f1491850d3d4"), new Guid("b659c2e0-f7e9-4258-a628-1e108831ddf0") },
                    { new Guid("ea94b18d-7c05-4e13-93ab-ab448452991e"), new Guid("b659c2e0-f7e9-4258-a628-1e108831ddf0") },
                    { new Guid("a8369011-960d-41e1-ab81-111106be561e"), new Guid("b659c2e0-f7e9-4258-a628-1e108831ddf0") },
                    { new Guid("4eb39313-02a6-4139-93e5-b39609fc4167"), new Guid("b659c2e0-f7e9-4258-a628-1e108831ddf0") },
                    { new Guid("0ce04084-dcb1-4250-8d7c-a73385cbb76d"), new Guid("b659c2e0-f7e9-4258-a628-1e108831ddf0") },
                    { new Guid("0eba1889-edc2-48c1-a5eb-45fc773e192c"), new Guid("b659c2e0-f7e9-4258-a628-1e108831ddf0") },
                    { new Guid("d23dba1f-e4ff-4392-aa3b-3a0d2a163cf5"), new Guid("8debb346-fef6-44d3-baa8-37a0a12291a0") },
                    { new Guid("9b15c06c-b07b-47c6-a95c-af95825180b3"), new Guid("8debb346-fef6-44d3-baa8-37a0a12291a0") },
                    { new Guid("10ef6655-5cfb-40d3-b4ea-138fdd9ffd77"), new Guid("8debb346-fef6-44d3-baa8-37a0a12291a0") },
                    { new Guid("35af062d-cdee-4bf2-8d10-3b2a4d5d35a4"), new Guid("8debb346-fef6-44d3-baa8-37a0a12291a0") },
                    { new Guid("39e90802-df2e-4f05-8bf0-ec3cda2782a5"), new Guid("8debb346-fef6-44d3-baa8-37a0a12291a0") },
                    { new Guid("fe7a07aa-7456-481a-971d-fcc0a65fb34e"), new Guid("87c3dfd2-eb9c-474c-bc20-d2586eff3fe2") },
                    { new Guid("fc13c569-da0c-4f19-bba0-f1491850d3d4"), new Guid("8debb346-fef6-44d3-baa8-37a0a12291a0") },
                    { new Guid("96c7a4ef-43d0-4d89-a3c9-5a3974f36533"), new Guid("9a608f65-9834-47d9-85ce-2818907b0a3b") },
                    { new Guid("9a848840-6c03-4df8-bfb4-1122c8400c06"), new Guid("9a608f65-9834-47d9-85ce-2818907b0a3b") },
                    { new Guid("1ccf53a1-ceb8-43cd-beb1-27efbdc8f25e"), new Guid("13c0cc5f-ad64-40bc-90b7-502e92e3d5c0") },
                    { new Guid("85602a47-13d3-4bc0-874e-3dcb5066a4b5"), new Guid("4acaf4bd-8b6c-4f99-aa82-9baaa28a0740") },
                    { new Guid("145da347-783c-4fec-b163-ec4c76b306c2"), new Guid("a01dd380-0986-4b18-8e90-523f64fe815b") },
                    { new Guid("85602a47-13d3-4bc0-874e-3dcb5066a4b5"), new Guid("a01dd380-0986-4b18-8e90-523f64fe815b") },
                    { new Guid("0b7ad369-255a-418e-85f0-ea9efcdbb04d"), new Guid("a01dd380-0986-4b18-8e90-523f64fe815b") },
                    { new Guid("1e792fe6-ab89-418e-8456-cfa05a433d25"), new Guid("a01dd380-0986-4b18-8e90-523f64fe815b") },
                    { new Guid("0b7ad369-255a-418e-85f0-ea9efcdbb04d"), new Guid("382167e3-7ce7-4422-8c80-e4b2c18934c0") },
                    { new Guid("4267f54f-70c8-4fa6-9f79-e6c7ffd35ef7"), new Guid("a48f9a90-f6a0-4f83-9750-b1ab9540a901") },
                    { new Guid("b82d52f2-4512-4ff0-a8e5-2ddcfe3bd2d6"), new Guid("a48f9a90-f6a0-4f83-9750-b1ab9540a901") },
                    { new Guid("595ca34e-fa75-4c0e-b730-62c19cd36fea"), new Guid("a48f9a90-f6a0-4f83-9750-b1ab9540a901") },
                    { new Guid("305ccacd-ed90-481e-8f8e-b28ce910cb97"), new Guid("a48f9a90-f6a0-4f83-9750-b1ab9540a901") }
                });

            migrationBuilder.InsertData(
                table: "LinkTags",
                columns: new[] { "LinkId", "TagId" },
                values: new object[,]
                {
                    { new Guid("8356106d-f708-48fb-9499-cf0dd3b677c5"), new Guid("a48f9a90-f6a0-4f83-9750-b1ab9540a901") },
                    { new Guid("4190e202-1477-40a2-935a-d85ba55d713a"), new Guid("9a608f65-9834-47d9-85ce-2818907b0a3b") },
                    { new Guid("9a848840-6c03-4df8-bfb4-1122c8400c06"), new Guid("a48f9a90-f6a0-4f83-9750-b1ab9540a901") },
                    { new Guid("96c7a4ef-43d0-4d89-a3c9-5a3974f36533"), new Guid("a48f9a90-f6a0-4f83-9750-b1ab9540a901") },
                    { new Guid("8356106d-f708-48fb-9499-cf0dd3b677c5"), new Guid("639f0d3d-61b8-4d41-95e2-c948ce30171d") },
                    { new Guid("9a848840-6c03-4df8-bfb4-1122c8400c06"), new Guid("3c85333d-03ce-4eea-b8f1-273a24cad04b") },
                    { new Guid("4190e202-1477-40a2-935a-d85ba55d713a"), new Guid("3c85333d-03ce-4eea-b8f1-273a24cad04b") },
                    { new Guid("96c7a4ef-43d0-4d89-a3c9-5a3974f36533"), new Guid("3c85333d-03ce-4eea-b8f1-273a24cad04b") },
                    { new Guid("9b15c06c-b07b-47c6-a95c-af95825180b3"), new Guid("9a608f65-9834-47d9-85ce-2818907b0a3b") },
                    { new Guid("8feb1de4-7011-4939-8ea1-25927280d0dd"), new Guid("9a608f65-9834-47d9-85ce-2818907b0a3b") },
                    { new Guid("10ef6655-5cfb-40d3-b4ea-138fdd9ffd77"), new Guid("9a608f65-9834-47d9-85ce-2818907b0a3b") },
                    { new Guid("fc13c569-da0c-4f19-bba0-f1491850d3d4"), new Guid("9a608f65-9834-47d9-85ce-2818907b0a3b") },
                    { new Guid("ea94b18d-7c05-4e13-93ab-ab448452991e"), new Guid("9a608f65-9834-47d9-85ce-2818907b0a3b") },
                    { new Guid("a8369011-960d-41e1-ab81-111106be561e"), new Guid("9a608f65-9834-47d9-85ce-2818907b0a3b") },
                    { new Guid("4eb39313-02a6-4139-93e5-b39609fc4167"), new Guid("9a608f65-9834-47d9-85ce-2818907b0a3b") },
                    { new Guid("4190e202-1477-40a2-935a-d85ba55d713a"), new Guid("a48f9a90-f6a0-4f83-9750-b1ab9540a901") },
                    { new Guid("ea94b18d-7c05-4e13-93ab-ab448452991e"), new Guid("bc289b4d-20e1-4696-a55f-ac9023161b31") },
                    { new Guid("a8369011-960d-41e1-ab81-111106be561e"), new Guid("bc289b4d-20e1-4696-a55f-ac9023161b31") },
                    { new Guid("4eb39313-02a6-4139-93e5-b39609fc4167"), new Guid("bc289b4d-20e1-4696-a55f-ac9023161b31") },
                    { new Guid("ea94b18d-7c05-4e13-93ab-ab448452991e"), new Guid("12abccf4-937a-48b4-8cfc-eacdc2eb4358") },
                    { new Guid("fc13c569-da0c-4f19-bba0-f1491850d3d4"), new Guid("e1683932-78a2-4ded-a23b-7729573aceca") },
                    { new Guid("b82d52f2-4512-4ff0-a8e5-2ddcfe3bd2d6"), new Guid("b22ec78a-cfb1-4278-905d-857b79f7fa0b") },
                    { new Guid("62673a98-212a-4086-81b8-c81c6d3d4dc1"), new Guid("cf0def79-5b99-4754-a775-b76f14f3bbe4") },
                    { new Guid("5ef9d6b1-47bd-4887-bfd2-e130f3f29cdc"), new Guid("8bb5da12-bd2f-4357-bfd3-7628ff23ac81") },
                    { new Guid("500dc1df-9607-4e2a-8a23-e138692382c5"), new Guid("6dc7eabd-f824-457f-a738-9bac58b5604b") },
                    { new Guid("8feb1de4-7011-4939-8ea1-25927280d0dd"), new Guid("6dc7eabd-f824-457f-a738-9bac58b5604b") },
                    { new Guid("fe7a07aa-7456-481a-971d-fcc0a65fb34e"), new Guid("9be2b66e-aacd-4110-b937-87e7de68aae9") },
                    { new Guid("ea94b18d-7c05-4e13-93ab-ab448452991e"), new Guid("233091f1-0bc4-402f-aca0-a64e057322f8") },
                    { new Guid("3334b097-20a9-453f-9ef7-919432abeb64"), new Guid("233091f1-0bc4-402f-aca0-a64e057322f8") },
                    { new Guid("a8369011-960d-41e1-ab81-111106be561e"), new Guid("233091f1-0bc4-402f-aca0-a64e057322f8") },
                    { new Guid("4eb39313-02a6-4139-93e5-b39609fc4167"), new Guid("233091f1-0bc4-402f-aca0-a64e057322f8") },
                    { new Guid("ea94b18d-7c05-4e13-93ab-ab448452991e"), new Guid("aba5e721-d45c-4da5-b9f7-6dab5bab3298") },
                    { new Guid("96c7a4ef-43d0-4d89-a3c9-5a3974f36533"), new Guid("ac00b15c-a093-483a-bc71-76f18843c2dc") },
                    { new Guid("62673a98-212a-4086-81b8-c81c6d3d4dc1"), new Guid("958fa84a-469b-42c3-a6f2-9ee4276b2e40") },
                    { new Guid("305ccacd-ed90-481e-8f8e-b28ce910cb97"), new Guid("958fa84a-469b-42c3-a6f2-9ee4276b2e40") },
                    { new Guid("8feb1de4-7011-4939-8ea1-25927280d0dd"), new Guid("958fa84a-469b-42c3-a6f2-9ee4276b2e40") },
                    { new Guid("5ef9d6b1-47bd-4887-bfd2-e130f3f29cdc"), new Guid("958fa84a-469b-42c3-a6f2-9ee4276b2e40") },
                    { new Guid("ea94b18d-7c05-4e13-93ab-ab448452991e"), new Guid("958fa84a-469b-42c3-a6f2-9ee4276b2e40") },
                    { new Guid("8356106d-f708-48fb-9499-cf0dd3b677c5"), new Guid("958fa84a-469b-42c3-a6f2-9ee4276b2e40") },
                    { new Guid("3334b097-20a9-453f-9ef7-919432abeb64"), new Guid("958fa84a-469b-42c3-a6f2-9ee4276b2e40") },
                    { new Guid("4eb39313-02a6-4139-93e5-b39609fc4167"), new Guid("958fa84a-469b-42c3-a6f2-9ee4276b2e40") },
                    { new Guid("0ce04084-dcb1-4250-8d7c-a73385cbb76d"), new Guid("958fa84a-469b-42c3-a6f2-9ee4276b2e40") }
                });

            migrationBuilder.InsertData(
                table: "LinkTags",
                columns: new[] { "LinkId", "TagId" },
                values: new object[,]
                {
                    { new Guid("0eba1889-edc2-48c1-a5eb-45fc773e192c"), new Guid("958fa84a-469b-42c3-a6f2-9ee4276b2e40") },
                    { new Guid("5dc91c8c-a8eb-4d04-8ca0-3de007d17cdc"), new Guid("e9052ff3-f1fa-4792-ab3f-5a25b3686031") },
                    { new Guid("305ccacd-ed90-481e-8f8e-b28ce910cb97"), new Guid("62025c26-33c8-47b1-919c-acb4191e3280") },
                    { new Guid("500dc1df-9607-4e2a-8a23-e138692382c5"), new Guid("958fa84a-469b-42c3-a6f2-9ee4276b2e40") },
                    { new Guid("a8369011-960d-41e1-ab81-111106be561e"), new Guid("5391b3cc-31be-4ed7-906b-969a08e11ac3") },
                    { new Guid("1ccf53a1-ceb8-43cd-beb1-27efbdc8f25e"), new Guid("021fcffe-e6d7-4f68-810b-2330116331b3") },
                    { new Guid("1ccf53a1-ceb8-43cd-beb1-27efbdc8f25e"), new Guid("fcc2ef68-57e6-4114-ad5f-cf3fb81e89a0") },
                    { new Guid("0eba1889-edc2-48c1-a5eb-45fc773e192c"), new Guid("bc289b4d-20e1-4696-a55f-ac9023161b31") },
                    { new Guid("0ce04084-dcb1-4250-8d7c-a73385cbb76d"), new Guid("55e88610-b070-42aa-8c99-533b2b881b05") },
                    { new Guid("4eb39313-02a6-4139-93e5-b39609fc4167"), new Guid("6df13233-ad61-45ff-942b-1857da99c0f1") },
                    { new Guid("d23dba1f-e4ff-4392-aa3b-3a0d2a163cf5"), new Guid("9e7303bc-730a-4d5c-a110-57029ffd7ff4") },
                    { new Guid("35af062d-cdee-4bf2-8d10-3b2a4d5d35a4"), new Guid("9e7303bc-730a-4d5c-a110-57029ffd7ff4") },
                    { new Guid("39e90802-df2e-4f05-8bf0-ec3cda2782a5"), new Guid("9e7303bc-730a-4d5c-a110-57029ffd7ff4") },
                    { new Guid("d23dba1f-e4ff-4392-aa3b-3a0d2a163cf5"), new Guid("a7f9abec-e209-4a5c-99e3-bdb3a679a2f7") },
                    { new Guid("9b15c06c-b07b-47c6-a95c-af95825180b3"), new Guid("a7f9abec-e209-4a5c-99e3-bdb3a679a2f7") },
                    { new Guid("a4efa4f5-19f6-43da-8710-34e12656dd36"), new Guid("a7f9abec-e209-4a5c-99e3-bdb3a679a2f7") },
                    { new Guid("10ef6655-5cfb-40d3-b4ea-138fdd9ffd77"), new Guid("a7f9abec-e209-4a5c-99e3-bdb3a679a2f7") },
                    { new Guid("35af062d-cdee-4bf2-8d10-3b2a4d5d35a4"), new Guid("a7f9abec-e209-4a5c-99e3-bdb3a679a2f7") },
                    { new Guid("39e90802-df2e-4f05-8bf0-ec3cda2782a5"), new Guid("a7f9abec-e209-4a5c-99e3-bdb3a679a2f7") },
                    { new Guid("62673a98-212a-4086-81b8-c81c6d3d4dc1"), new Guid("a6ce6fc1-ebf4-4286-80da-fccf5aa60266") },
                    { new Guid("4267f54f-70c8-4fa6-9f79-e6c7ffd35ef7"), new Guid("344c0405-f0b9-408e-ae56-063bfa06d705") },
                    { new Guid("b82d52f2-4512-4ff0-a8e5-2ddcfe3bd2d6"), new Guid("344c0405-f0b9-408e-ae56-063bfa06d705") },
                    { new Guid("4267f54f-70c8-4fa6-9f79-e6c7ffd35ef7"), new Guid("381184be-55af-4f55-9fd5-94a5c5864582") },
                    { new Guid("4267f54f-70c8-4fa6-9f79-e6c7ffd35ef7"), new Guid("40f84a57-8260-47c3-8e53-55f5c67719c6") },
                    { new Guid("5dc91c8c-a8eb-4d04-8ca0-3de007d17cdc"), new Guid("3a06d804-0635-4cd0-81ca-4dbcab0e5c40") },
                    { new Guid("1921a6cb-7ef9-47ba-ba7c-0bc7f47d028c"), new Guid("3a06d804-0635-4cd0-81ca-4dbcab0e5c40") },
                    { new Guid("fc13c569-da0c-4f19-bba0-f1491850d3d4"), new Guid("f0d0e2f7-f03c-46df-8a6a-4e94cf4dce55") },
                    { new Guid("1ccf53a1-ceb8-43cd-beb1-27efbdc8f25e"), new Guid("244c117c-e184-473b-9131-02fc45d1b4e5") },
                    { new Guid("145da347-783c-4fec-b163-ec4c76b306c2"), new Guid("b7cc1c6f-ca92-4c00-b899-cdc0aba0590b") },
                    { new Guid("85602a47-13d3-4bc0-874e-3dcb5066a4b5"), new Guid("b7cc1c6f-ca92-4c00-b899-cdc0aba0590b") },
                    { new Guid("0b7ad369-255a-418e-85f0-ea9efcdbb04d"), new Guid("b7cc1c6f-ca92-4c00-b899-cdc0aba0590b") },
                    { new Guid("1e792fe6-ab89-418e-8456-cfa05a433d25"), new Guid("b7cc1c6f-ca92-4c00-b899-cdc0aba0590b") },
                    { new Guid("1921a6cb-7ef9-47ba-ba7c-0bc7f47d028c"), new Guid("b7cc1c6f-ca92-4c00-b899-cdc0aba0590b") },
                    { new Guid("1921a6cb-7ef9-47ba-ba7c-0bc7f47d028c"), new Guid("45e34501-421a-4ba3-85d2-b07eb71c3f5c") },
                    { new Guid("a8369011-960d-41e1-ab81-111106be561e"), new Guid("13c0cc5f-ad64-40bc-90b7-502e92e3d5c0") },
                    { new Guid("8feb1de4-7011-4939-8ea1-25927280d0dd"), new Guid("62025c26-33c8-47b1-919c-acb4191e3280") },
                    { new Guid("1921a6cb-7ef9-47ba-ba7c-0bc7f47d028c"), new Guid("13c0cc5f-ad64-40bc-90b7-502e92e3d5c0") },
                    { new Guid("5dc91c8c-a8eb-4d04-8ca0-3de007d17cdc"), new Guid("13c0cc5f-ad64-40bc-90b7-502e92e3d5c0") },
                    { new Guid("a4efa4f5-19f6-43da-8710-34e12656dd36"), new Guid("545a3223-1a97-43a2-ae74-60ff4dd2b7ec") },
                    { new Guid("10ef6655-5cfb-40d3-b4ea-138fdd9ffd77"), new Guid("545a3223-1a97-43a2-ae74-60ff4dd2b7ec") },
                    { new Guid("35af062d-cdee-4bf2-8d10-3b2a4d5d35a4"), new Guid("545a3223-1a97-43a2-ae74-60ff4dd2b7ec") },
                    { new Guid("39e90802-df2e-4f05-8bf0-ec3cda2782a5"), new Guid("545a3223-1a97-43a2-ae74-60ff4dd2b7ec") }
                });

            migrationBuilder.InsertData(
                table: "LinkTags",
                columns: new[] { "LinkId", "TagId" },
                values: new object[,]
                {
                    { new Guid("1a627430-6cef-4a81-88f2-79ee9adfcb12"), new Guid("545a3223-1a97-43a2-ae74-60ff4dd2b7ec") },
                    { new Guid("fc13c569-da0c-4f19-bba0-f1491850d3d4"), new Guid("545a3223-1a97-43a2-ae74-60ff4dd2b7ec") },
                    { new Guid("3334b097-20a9-453f-9ef7-919432abeb64"), new Guid("545a3223-1a97-43a2-ae74-60ff4dd2b7ec") },
                    { new Guid("9a848840-6c03-4df8-bfb4-1122c8400c06"), new Guid("545a3223-1a97-43a2-ae74-60ff4dd2b7ec") },
                    { new Guid("4190e202-1477-40a2-935a-d85ba55d713a"), new Guid("545a3223-1a97-43a2-ae74-60ff4dd2b7ec") },
                    { new Guid("96c7a4ef-43d0-4d89-a3c9-5a3974f36533"), new Guid("545a3223-1a97-43a2-ae74-60ff4dd2b7ec") },
                    { new Guid("62673a98-212a-4086-81b8-c81c6d3d4dc1"), new Guid("9cb56da2-a1a1-4f5a-bf76-5392d0a9b049") },
                    { new Guid("b59efa1b-9b14-4313-bf8a-18088bc3ad8c"), new Guid("9cb56da2-a1a1-4f5a-bf76-5392d0a9b049") },
                    { new Guid("a2bdc0c4-fea7-4e66-90dc-a5d068c854b9"), new Guid("545a3223-1a97-43a2-ae74-60ff4dd2b7ec") },
                    { new Guid("b59efa1b-9b14-4313-bf8a-18088bc3ad8c"), new Guid("3d5838f2-4fff-4350-8de1-b6041ef68c9a") },
                    { new Guid("b59efa1b-9b14-4313-bf8a-18088bc3ad8c"), new Guid("2d6c9fcb-a933-4912-a16c-4ad290777cb8") },
                    { new Guid("43dfcbd5-f4ac-44bc-a801-660061e53125"), new Guid("2d6c9fcb-a933-4912-a16c-4ad290777cb8") },
                    { new Guid("62673a98-212a-4086-81b8-c81c6d3d4dc1"), new Guid("890985c5-b423-4fd4-bf40-91aa9bd2e5dc") },
                    { new Guid("5dc91c8c-a8eb-4d04-8ca0-3de007d17cdc"), new Guid("890985c5-b423-4fd4-bf40-91aa9bd2e5dc") },
                    { new Guid("43dfcbd5-f4ac-44bc-a801-660061e53125"), new Guid("890985c5-b423-4fd4-bf40-91aa9bd2e5dc") },
                    { new Guid("6058a82e-c1dc-414c-90c3-200a97944b8d"), new Guid("d416b04b-83b2-4f36-83bf-5b7fa817ee2c") },
                    { new Guid("500dc1df-9607-4e2a-8a23-e138692382c5"), new Guid("d416b04b-83b2-4f36-83bf-5b7fa817ee2c") },
                    { new Guid("89db9df9-b7aa-44da-a446-a240e64d4b5c"), new Guid("d416b04b-83b2-4f36-83bf-5b7fa817ee2c") },
                    { new Guid("7f411aa8-26af-48f8-8b69-5e7025b4a935"), new Guid("d416b04b-83b2-4f36-83bf-5b7fa817ee2c") },
                    { new Guid("305ccacd-ed90-481e-8f8e-b28ce910cb97"), new Guid("d416b04b-83b2-4f36-83bf-5b7fa817ee2c") },
                    { new Guid("578a9540-9f86-48f7-8dea-ab1db8033422"), new Guid("d416b04b-83b2-4f36-83bf-5b7fa817ee2c") },
                    { new Guid("43dfcbd5-f4ac-44bc-a801-660061e53125"), new Guid("d416b04b-83b2-4f36-83bf-5b7fa817ee2c") },
                    { new Guid("62bcbadc-1b42-437f-9a13-3f52d76123aa"), new Guid("3d5838f2-4fff-4350-8de1-b6041ef68c9a") },
                    { new Guid("8356106d-f708-48fb-9499-cf0dd3b677c5"), new Guid("d416b04b-83b2-4f36-83bf-5b7fa817ee2c") },
                    { new Guid("578a9540-9f86-48f7-8dea-ab1db8033422"), new Guid("545a3223-1a97-43a2-ae74-60ff4dd2b7ec") },
                    { new Guid("7f411aa8-26af-48f8-8b69-5e7025b4a935"), new Guid("545a3223-1a97-43a2-ae74-60ff4dd2b7ec") },
                    { new Guid("500dc1df-9607-4e2a-8a23-e138692382c5"), new Guid("cbbc812e-3cab-42b9-aeca-f91cf21194c1") },
                    { new Guid("89db9df9-b7aa-44da-a446-a240e64d4b5c"), new Guid("cbbc812e-3cab-42b9-aeca-f91cf21194c1") },
                    { new Guid("c2b77138-6689-49cc-9d79-39389c20cee2"), new Guid("cbbc812e-3cab-42b9-aeca-f91cf21194c1") },
                    { new Guid("4267f54f-70c8-4fa6-9f79-e6c7ffd35ef7"), new Guid("cbbc812e-3cab-42b9-aeca-f91cf21194c1") },
                    { new Guid("9b15c06c-b07b-47c6-a95c-af95825180b3"), new Guid("cbbc812e-3cab-42b9-aeca-f91cf21194c1") },
                    { new Guid("b82d52f2-4512-4ff0-a8e5-2ddcfe3bd2d6"), new Guid("cbbc812e-3cab-42b9-aeca-f91cf21194c1") },
                    { new Guid("7f411aa8-26af-48f8-8b69-5e7025b4a935"), new Guid("cbbc812e-3cab-42b9-aeca-f91cf21194c1") },
                    { new Guid("595ca34e-fa75-4c0e-b730-62c19cd36fea"), new Guid("cbbc812e-3cab-42b9-aeca-f91cf21194c1") },
                    { new Guid("305ccacd-ed90-481e-8f8e-b28ce910cb97"), new Guid("cbbc812e-3cab-42b9-aeca-f91cf21194c1") },
                    { new Guid("1921a6cb-7ef9-47ba-ba7c-0bc7f47d028c"), new Guid("cbbc812e-3cab-42b9-aeca-f91cf21194c1") },
                    { new Guid("b59efa1b-9b14-4313-bf8a-18088bc3ad8c"), new Guid("cbbc812e-3cab-42b9-aeca-f91cf21194c1") },
                    { new Guid("8feb1de4-7011-4939-8ea1-25927280d0dd"), new Guid("cbbc812e-3cab-42b9-aeca-f91cf21194c1") },
                    { new Guid("b59efa1b-9b14-4313-bf8a-18088bc3ad8c"), new Guid("545a3223-1a97-43a2-ae74-60ff4dd2b7ec") },
                    { new Guid("578a9540-9f86-48f7-8dea-ab1db8033422"), new Guid("cbbc812e-3cab-42b9-aeca-f91cf21194c1") },
                    { new Guid("a4efa4f5-19f6-43da-8710-34e12656dd36"), new Guid("cbbc812e-3cab-42b9-aeca-f91cf21194c1") },
                    { new Guid("10ef6655-5cfb-40d3-b4ea-138fdd9ffd77"), new Guid("cbbc812e-3cab-42b9-aeca-f91cf21194c1") }
                });

            migrationBuilder.InsertData(
                table: "LinkTags",
                columns: new[] { "LinkId", "TagId" },
                values: new object[,]
                {
                    { new Guid("1a627430-6cef-4a81-88f2-79ee9adfcb12"), new Guid("cbbc812e-3cab-42b9-aeca-f91cf21194c1") },
                    { new Guid("c2b77138-6689-49cc-9d79-39389c20cee2"), new Guid("a8fd4501-4100-497b-8a17-8ddba4fd7886") },
                    { new Guid("9a848840-6c03-4df8-bfb4-1122c8400c06"), new Guid("a8fd4501-4100-497b-8a17-8ddba4fd7886") },
                    { new Guid("4190e202-1477-40a2-935a-d85ba55d713a"), new Guid("a8fd4501-4100-497b-8a17-8ddba4fd7886") },
                    { new Guid("96c7a4ef-43d0-4d89-a3c9-5a3974f36533"), new Guid("a8fd4501-4100-497b-8a17-8ddba4fd7886") },
                    { new Guid("c2b77138-6689-49cc-9d79-39389c20cee2"), new Guid("37b9e987-6a33-4514-a6d2-835903743369") },
                    { new Guid("6058a82e-c1dc-414c-90c3-200a97944b8d"), new Guid("545a3223-1a97-43a2-ae74-60ff4dd2b7ec") },
                    { new Guid("500dc1df-9607-4e2a-8a23-e138692382c5"), new Guid("545a3223-1a97-43a2-ae74-60ff4dd2b7ec") },
                    { new Guid("89db9df9-b7aa-44da-a446-a240e64d4b5c"), new Guid("545a3223-1a97-43a2-ae74-60ff4dd2b7ec") },
                    { new Guid("d23dba1f-e4ff-4392-aa3b-3a0d2a163cf5"), new Guid("545a3223-1a97-43a2-ae74-60ff4dd2b7ec") },
                    { new Guid("62bcbadc-1b42-437f-9a13-3f52d76123aa"), new Guid("cbbc812e-3cab-42b9-aeca-f91cf21194c1") },
                    { new Guid("62bcbadc-1b42-437f-9a13-3f52d76123aa"), new Guid("48d069a2-9c39-4665-9485-22e4b56a7972") },
                    { new Guid("6058a82e-c1dc-414c-90c3-200a97944b8d"), new Guid("e9c19fff-b42b-49d1-8309-02ae412a60de") },
                    { new Guid("500dc1df-9607-4e2a-8a23-e138692382c5"), new Guid("e9c19fff-b42b-49d1-8309-02ae412a60de") },
                    { new Guid("0ce04084-dcb1-4250-8d7c-a73385cbb76d"), new Guid("aacd600b-0eeb-4a52-b147-0f209549885f") },
                    { new Guid("fe7a07aa-7456-481a-971d-fcc0a65fb34e"), new Guid("aacd600b-0eeb-4a52-b147-0f209549885f") },
                    { new Guid("0eba1889-edc2-48c1-a5eb-45fc773e192c"), new Guid("aacd600b-0eeb-4a52-b147-0f209549885f") },
                    { new Guid("62bcbadc-1b42-437f-9a13-3f52d76123aa"), new Guid("19ccee14-002c-4bd0-a205-caa0c6acbe36") },
                    { new Guid("62bcbadc-1b42-437f-9a13-3f52d76123aa"), new Guid("96bd77d3-3448-4fb8-88ff-80eed4e40737") },
                    { new Guid("43dfcbd5-f4ac-44bc-a801-660061e53125"), new Guid("9507c750-c643-47a7-90d3-46633c16c237") },
                    { new Guid("4267f54f-70c8-4fa6-9f79-e6c7ffd35ef7"), new Guid("cc857f6e-0f23-481a-8a21-19164e6414f1") },
                    { new Guid("595ca34e-fa75-4c0e-b730-62c19cd36fea"), new Guid("cc857f6e-0f23-481a-8a21-19164e6414f1") },
                    { new Guid("305ccacd-ed90-481e-8f8e-b28ce910cb97"), new Guid("cc857f6e-0f23-481a-8a21-19164e6414f1") },
                    { new Guid("4190e202-1477-40a2-935a-d85ba55d713a"), new Guid("cc857f6e-0f23-481a-8a21-19164e6414f1") },
                    { new Guid("96c7a4ef-43d0-4d89-a3c9-5a3974f36533"), new Guid("cc857f6e-0f23-481a-8a21-19164e6414f1") },
                    { new Guid("43dfcbd5-f4ac-44bc-a801-660061e53125"), new Guid("7a59d506-1192-47b3-a46d-6ec3a7f88664") },
                    { new Guid("3334b097-20a9-453f-9ef7-919432abeb64"), new Guid("aacd600b-0eeb-4a52-b147-0f209549885f") },
                    { new Guid("a2bdc0c4-fea7-4e66-90dc-a5d068c854b9"), new Guid("dc97a1f5-a068-4ea9-8513-84564acac4c1") },
                    { new Guid("7f411aa8-26af-48f8-8b69-5e7025b4a935"), new Guid("ecf04aee-4f83-4631-998d-f398684a1824") },
                    { new Guid("578a9540-9f86-48f7-8dea-ab1db8033422"), new Guid("ecf04aee-4f83-4631-998d-f398684a1824") },
                    { new Guid("a2bdc0c4-fea7-4e66-90dc-a5d068c854b9"), new Guid("ecf04aee-4f83-4631-998d-f398684a1824") },
                    { new Guid("1e792fe6-ab89-418e-8456-cfa05a433d25"), new Guid("dc31bb70-1d06-4b28-9ba8-308a56ee9209") },
                    { new Guid("a2bdc0c4-fea7-4e66-90dc-a5d068c854b9"), new Guid("dc31bb70-1d06-4b28-9ba8-308a56ee9209") },
                    { new Guid("6058a82e-c1dc-414c-90c3-200a97944b8d"), new Guid("2a8f120d-fb1c-4cf8-8f2b-65179bfe59fc") },
                    { new Guid("89db9df9-b7aa-44da-a446-a240e64d4b5c"), new Guid("2a8f120d-fb1c-4cf8-8f2b-65179bfe59fc") },
                    { new Guid("7f411aa8-26af-48f8-8b69-5e7025b4a935"), new Guid("2a8f120d-fb1c-4cf8-8f2b-65179bfe59fc") },
                    { new Guid("578a9540-9f86-48f7-8dea-ab1db8033422"), new Guid("2a8f120d-fb1c-4cf8-8f2b-65179bfe59fc") },
                    { new Guid("1a627430-6cef-4a81-88f2-79ee9adfcb12"), new Guid("2a8f120d-fb1c-4cf8-8f2b-65179bfe59fc") },
                    { new Guid("6058a82e-c1dc-414c-90c3-200a97944b8d"), new Guid("23e31995-07e9-4ef1-a79c-297d29e5c8dd") },
                    { new Guid("1a627430-6cef-4a81-88f2-79ee9adfcb12"), new Guid("61d18801-8587-4763-862d-1dc0c69d831a") },
                    { new Guid("89db9df9-b7aa-44da-a446-a240e64d4b5c"), new Guid("ecf04aee-4f83-4631-998d-f398684a1824") },
                    { new Guid("ea94b18d-7c05-4e13-93ab-ab448452991e"), new Guid("aacd600b-0eeb-4a52-b147-0f209549885f") }
                });

            migrationBuilder.InsertData(
                table: "LinkTags",
                columns: new[] { "LinkId", "TagId" },
                values: new object[,]
                {
                    { new Guid("fc13c569-da0c-4f19-bba0-f1491850d3d4"), new Guid("aacd600b-0eeb-4a52-b147-0f209549885f") },
                    { new Guid("1a627430-6cef-4a81-88f2-79ee9adfcb12"), new Guid("aacd600b-0eeb-4a52-b147-0f209549885f") },
                    { new Guid("89db9df9-b7aa-44da-a446-a240e64d4b5c"), new Guid("e9c19fff-b42b-49d1-8309-02ae412a60de") },
                    { new Guid("d23dba1f-e4ff-4392-aa3b-3a0d2a163cf5"), new Guid("e9c19fff-b42b-49d1-8309-02ae412a60de") },
                    { new Guid("9b15c06c-b07b-47c6-a95c-af95825180b3"), new Guid("e9c19fff-b42b-49d1-8309-02ae412a60de") },
                    { new Guid("b82d52f2-4512-4ff0-a8e5-2ddcfe3bd2d6"), new Guid("e9c19fff-b42b-49d1-8309-02ae412a60de") },
                    { new Guid("7f411aa8-26af-48f8-8b69-5e7025b4a935"), new Guid("e9c19fff-b42b-49d1-8309-02ae412a60de") },
                    { new Guid("8feb1de4-7011-4939-8ea1-25927280d0dd"), new Guid("e9c19fff-b42b-49d1-8309-02ae412a60de") },
                    { new Guid("578a9540-9f86-48f7-8dea-ab1db8033422"), new Guid("e9c19fff-b42b-49d1-8309-02ae412a60de") },
                    { new Guid("43dfcbd5-f4ac-44bc-a801-660061e53125"), new Guid("e9c19fff-b42b-49d1-8309-02ae412a60de") },
                    { new Guid("62bcbadc-1b42-437f-9a13-3f52d76123aa"), new Guid("e9c19fff-b42b-49d1-8309-02ae412a60de") },
                    { new Guid("a2bdc0c4-fea7-4e66-90dc-a5d068c854b9"), new Guid("e9c19fff-b42b-49d1-8309-02ae412a60de") },
                    { new Guid("39e90802-df2e-4f05-8bf0-ec3cda2782a5"), new Guid("e9c19fff-b42b-49d1-8309-02ae412a60de") },
                    { new Guid("5ef9d6b1-47bd-4887-bfd2-e130f3f29cdc"), new Guid("e9c19fff-b42b-49d1-8309-02ae412a60de") },
                    { new Guid("1a627430-6cef-4a81-88f2-79ee9adfcb12"), new Guid("e9c19fff-b42b-49d1-8309-02ae412a60de") },
                    { new Guid("fc13c569-da0c-4f19-bba0-f1491850d3d4"), new Guid("e9c19fff-b42b-49d1-8309-02ae412a60de") },
                    { new Guid("ea94b18d-7c05-4e13-93ab-ab448452991e"), new Guid("e9c19fff-b42b-49d1-8309-02ae412a60de") },
                    { new Guid("8356106d-f708-48fb-9499-cf0dd3b677c5"), new Guid("e9c19fff-b42b-49d1-8309-02ae412a60de") },
                    { new Guid("3334b097-20a9-453f-9ef7-919432abeb64"), new Guid("e9c19fff-b42b-49d1-8309-02ae412a60de") },
                    { new Guid("0ce04084-dcb1-4250-8d7c-a73385cbb76d"), new Guid("e9c19fff-b42b-49d1-8309-02ae412a60de") },
                    { new Guid("6058a82e-c1dc-414c-90c3-200a97944b8d"), new Guid("aacd600b-0eeb-4a52-b147-0f209549885f") },
                    { new Guid("d23dba1f-e4ff-4392-aa3b-3a0d2a163cf5"), new Guid("aacd600b-0eeb-4a52-b147-0f209549885f") },
                    { new Guid("9b15c06c-b07b-47c6-a95c-af95825180b3"), new Guid("aacd600b-0eeb-4a52-b147-0f209549885f") },
                    { new Guid("b82d52f2-4512-4ff0-a8e5-2ddcfe3bd2d6"), new Guid("aacd600b-0eeb-4a52-b147-0f209549885f") },
                    { new Guid("8feb1de4-7011-4939-8ea1-25927280d0dd"), new Guid("aacd600b-0eeb-4a52-b147-0f209549885f") },
                    { new Guid("62bcbadc-1b42-437f-9a13-3f52d76123aa"), new Guid("aacd600b-0eeb-4a52-b147-0f209549885f") },
                    { new Guid("35af062d-cdee-4bf2-8d10-3b2a4d5d35a4"), new Guid("aacd600b-0eeb-4a52-b147-0f209549885f") },
                    { new Guid("39e90802-df2e-4f05-8bf0-ec3cda2782a5"), new Guid("aacd600b-0eeb-4a52-b147-0f209549885f") },
                    { new Guid("5ef9d6b1-47bd-4887-bfd2-e130f3f29cdc"), new Guid("aacd600b-0eeb-4a52-b147-0f209549885f") },
                    { new Guid("145da347-783c-4fec-b163-ec4c76b306c2"), new Guid("13c0cc5f-ad64-40bc-90b7-502e92e3d5c0") },
                    { new Guid("10ef6655-5cfb-40d3-b4ea-138fdd9ffd77"), new Guid("62025c26-33c8-47b1-919c-acb4191e3280") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("0b7ad369-255a-418e-85f0-ea9efcdbb04d"), new Guid("382167e3-7ce7-4422-8c80-e4b2c18934c0") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("0b7ad369-255a-418e-85f0-ea9efcdbb04d"), new Guid("a01dd380-0986-4b18-8e90-523f64fe815b") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("0b7ad369-255a-418e-85f0-ea9efcdbb04d"), new Guid("b7cc1c6f-ca92-4c00-b899-cdc0aba0590b") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("0ce04084-dcb1-4250-8d7c-a73385cbb76d"), new Guid("55e88610-b070-42aa-8c99-533b2b881b05") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("0ce04084-dcb1-4250-8d7c-a73385cbb76d"), new Guid("958fa84a-469b-42c3-a6f2-9ee4276b2e40") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("0ce04084-dcb1-4250-8d7c-a73385cbb76d"), new Guid("aacd600b-0eeb-4a52-b147-0f209549885f") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("0ce04084-dcb1-4250-8d7c-a73385cbb76d"), new Guid("b659c2e0-f7e9-4258-a628-1e108831ddf0") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("0ce04084-dcb1-4250-8d7c-a73385cbb76d"), new Guid("e9c19fff-b42b-49d1-8309-02ae412a60de") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("0eba1889-edc2-48c1-a5eb-45fc773e192c"), new Guid("87c3dfd2-eb9c-474c-bc20-d2586eff3fe2") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("0eba1889-edc2-48c1-a5eb-45fc773e192c"), new Guid("958fa84a-469b-42c3-a6f2-9ee4276b2e40") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("0eba1889-edc2-48c1-a5eb-45fc773e192c"), new Guid("9a608f65-9834-47d9-85ce-2818907b0a3b") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("0eba1889-edc2-48c1-a5eb-45fc773e192c"), new Guid("aacd600b-0eeb-4a52-b147-0f209549885f") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("0eba1889-edc2-48c1-a5eb-45fc773e192c"), new Guid("b659c2e0-f7e9-4258-a628-1e108831ddf0") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("0eba1889-edc2-48c1-a5eb-45fc773e192c"), new Guid("bc289b4d-20e1-4696-a55f-ac9023161b31") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("10ef6655-5cfb-40d3-b4ea-138fdd9ffd77"), new Guid("545a3223-1a97-43a2-ae74-60ff4dd2b7ec") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("10ef6655-5cfb-40d3-b4ea-138fdd9ffd77"), new Guid("62025c26-33c8-47b1-919c-acb4191e3280") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("10ef6655-5cfb-40d3-b4ea-138fdd9ffd77"), new Guid("8debb346-fef6-44d3-baa8-37a0a12291a0") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("10ef6655-5cfb-40d3-b4ea-138fdd9ffd77"), new Guid("9a608f65-9834-47d9-85ce-2818907b0a3b") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("10ef6655-5cfb-40d3-b4ea-138fdd9ffd77"), new Guid("a7f9abec-e209-4a5c-99e3-bdb3a679a2f7") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("10ef6655-5cfb-40d3-b4ea-138fdd9ffd77"), new Guid("cbbc812e-3cab-42b9-aeca-f91cf21194c1") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("145da347-783c-4fec-b163-ec4c76b306c2"), new Guid("13c0cc5f-ad64-40bc-90b7-502e92e3d5c0") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("145da347-783c-4fec-b163-ec4c76b306c2"), new Guid("a01dd380-0986-4b18-8e90-523f64fe815b") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("145da347-783c-4fec-b163-ec4c76b306c2"), new Guid("b7cc1c6f-ca92-4c00-b899-cdc0aba0590b") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("1921a6cb-7ef9-47ba-ba7c-0bc7f47d028c"), new Guid("13c0cc5f-ad64-40bc-90b7-502e92e3d5c0") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("1921a6cb-7ef9-47ba-ba7c-0bc7f47d028c"), new Guid("3a06d804-0635-4cd0-81ca-4dbcab0e5c40") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("1921a6cb-7ef9-47ba-ba7c-0bc7f47d028c"), new Guid("45e34501-421a-4ba3-85d2-b07eb71c3f5c") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("1921a6cb-7ef9-47ba-ba7c-0bc7f47d028c"), new Guid("b7cc1c6f-ca92-4c00-b899-cdc0aba0590b") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("1921a6cb-7ef9-47ba-ba7c-0bc7f47d028c"), new Guid("cbbc812e-3cab-42b9-aeca-f91cf21194c1") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("1a627430-6cef-4a81-88f2-79ee9adfcb12"), new Guid("2a8f120d-fb1c-4cf8-8f2b-65179bfe59fc") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("1a627430-6cef-4a81-88f2-79ee9adfcb12"), new Guid("545a3223-1a97-43a2-ae74-60ff4dd2b7ec") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("1a627430-6cef-4a81-88f2-79ee9adfcb12"), new Guid("61d18801-8587-4763-862d-1dc0c69d831a") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("1a627430-6cef-4a81-88f2-79ee9adfcb12"), new Guid("aacd600b-0eeb-4a52-b147-0f209549885f") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("1a627430-6cef-4a81-88f2-79ee9adfcb12"), new Guid("cbbc812e-3cab-42b9-aeca-f91cf21194c1") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("1a627430-6cef-4a81-88f2-79ee9adfcb12"), new Guid("e9c19fff-b42b-49d1-8309-02ae412a60de") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("1ccf53a1-ceb8-43cd-beb1-27efbdc8f25e"), new Guid("021fcffe-e6d7-4f68-810b-2330116331b3") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("1ccf53a1-ceb8-43cd-beb1-27efbdc8f25e"), new Guid("13c0cc5f-ad64-40bc-90b7-502e92e3d5c0") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("1ccf53a1-ceb8-43cd-beb1-27efbdc8f25e"), new Guid("244c117c-e184-473b-9131-02fc45d1b4e5") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("1ccf53a1-ceb8-43cd-beb1-27efbdc8f25e"), new Guid("fcc2ef68-57e6-4114-ad5f-cf3fb81e89a0") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("1e792fe6-ab89-418e-8456-cfa05a433d25"), new Guid("a01dd380-0986-4b18-8e90-523f64fe815b") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("1e792fe6-ab89-418e-8456-cfa05a433d25"), new Guid("b7cc1c6f-ca92-4c00-b899-cdc0aba0590b") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("1e792fe6-ab89-418e-8456-cfa05a433d25"), new Guid("dc31bb70-1d06-4b28-9ba8-308a56ee9209") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("305ccacd-ed90-481e-8f8e-b28ce910cb97"), new Guid("62025c26-33c8-47b1-919c-acb4191e3280") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("305ccacd-ed90-481e-8f8e-b28ce910cb97"), new Guid("958fa84a-469b-42c3-a6f2-9ee4276b2e40") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("305ccacd-ed90-481e-8f8e-b28ce910cb97"), new Guid("a48f9a90-f6a0-4f83-9750-b1ab9540a901") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("305ccacd-ed90-481e-8f8e-b28ce910cb97"), new Guid("a69946bc-acb4-4f7d-9eb0-7ed4f0ebac40") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("305ccacd-ed90-481e-8f8e-b28ce910cb97"), new Guid("cbbc812e-3cab-42b9-aeca-f91cf21194c1") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("305ccacd-ed90-481e-8f8e-b28ce910cb97"), new Guid("cc857f6e-0f23-481a-8a21-19164e6414f1") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("305ccacd-ed90-481e-8f8e-b28ce910cb97"), new Guid("d416b04b-83b2-4f36-83bf-5b7fa817ee2c") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("3334b097-20a9-453f-9ef7-919432abeb64"), new Guid("233091f1-0bc4-402f-aca0-a64e057322f8") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("3334b097-20a9-453f-9ef7-919432abeb64"), new Guid("545a3223-1a97-43a2-ae74-60ff4dd2b7ec") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("3334b097-20a9-453f-9ef7-919432abeb64"), new Guid("958fa84a-469b-42c3-a6f2-9ee4276b2e40") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("3334b097-20a9-453f-9ef7-919432abeb64"), new Guid("aacd600b-0eeb-4a52-b147-0f209549885f") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("3334b097-20a9-453f-9ef7-919432abeb64"), new Guid("e9c19fff-b42b-49d1-8309-02ae412a60de") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("35af062d-cdee-4bf2-8d10-3b2a4d5d35a4"), new Guid("545a3223-1a97-43a2-ae74-60ff4dd2b7ec") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("35af062d-cdee-4bf2-8d10-3b2a4d5d35a4"), new Guid("8debb346-fef6-44d3-baa8-37a0a12291a0") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("35af062d-cdee-4bf2-8d10-3b2a4d5d35a4"), new Guid("9e7303bc-730a-4d5c-a110-57029ffd7ff4") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("35af062d-cdee-4bf2-8d10-3b2a4d5d35a4"), new Guid("a7f9abec-e209-4a5c-99e3-bdb3a679a2f7") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("35af062d-cdee-4bf2-8d10-3b2a4d5d35a4"), new Guid("aacd600b-0eeb-4a52-b147-0f209549885f") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("39e90802-df2e-4f05-8bf0-ec3cda2782a5"), new Guid("545a3223-1a97-43a2-ae74-60ff4dd2b7ec") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("39e90802-df2e-4f05-8bf0-ec3cda2782a5"), new Guid("8debb346-fef6-44d3-baa8-37a0a12291a0") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("39e90802-df2e-4f05-8bf0-ec3cda2782a5"), new Guid("9e7303bc-730a-4d5c-a110-57029ffd7ff4") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("39e90802-df2e-4f05-8bf0-ec3cda2782a5"), new Guid("a7f9abec-e209-4a5c-99e3-bdb3a679a2f7") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("39e90802-df2e-4f05-8bf0-ec3cda2782a5"), new Guid("aacd600b-0eeb-4a52-b147-0f209549885f") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("39e90802-df2e-4f05-8bf0-ec3cda2782a5"), new Guid("e9c19fff-b42b-49d1-8309-02ae412a60de") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("4190e202-1477-40a2-935a-d85ba55d713a"), new Guid("3c85333d-03ce-4eea-b8f1-273a24cad04b") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("4190e202-1477-40a2-935a-d85ba55d713a"), new Guid("545a3223-1a97-43a2-ae74-60ff4dd2b7ec") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("4190e202-1477-40a2-935a-d85ba55d713a"), new Guid("9a608f65-9834-47d9-85ce-2818907b0a3b") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("4190e202-1477-40a2-935a-d85ba55d713a"), new Guid("a48f9a90-f6a0-4f83-9750-b1ab9540a901") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("4190e202-1477-40a2-935a-d85ba55d713a"), new Guid("a8fd4501-4100-497b-8a17-8ddba4fd7886") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("4190e202-1477-40a2-935a-d85ba55d713a"), new Guid("cc857f6e-0f23-481a-8a21-19164e6414f1") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("4267f54f-70c8-4fa6-9f79-e6c7ffd35ef7"), new Guid("344c0405-f0b9-408e-ae56-063bfa06d705") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("4267f54f-70c8-4fa6-9f79-e6c7ffd35ef7"), new Guid("381184be-55af-4f55-9fd5-94a5c5864582") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("4267f54f-70c8-4fa6-9f79-e6c7ffd35ef7"), new Guid("40f84a57-8260-47c3-8e53-55f5c67719c6") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("4267f54f-70c8-4fa6-9f79-e6c7ffd35ef7"), new Guid("a48f9a90-f6a0-4f83-9750-b1ab9540a901") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("4267f54f-70c8-4fa6-9f79-e6c7ffd35ef7"), new Guid("cbbc812e-3cab-42b9-aeca-f91cf21194c1") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("4267f54f-70c8-4fa6-9f79-e6c7ffd35ef7"), new Guid("cc857f6e-0f23-481a-8a21-19164e6414f1") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("43dfcbd5-f4ac-44bc-a801-660061e53125"), new Guid("2d6c9fcb-a933-4912-a16c-4ad290777cb8") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("43dfcbd5-f4ac-44bc-a801-660061e53125"), new Guid("7a59d506-1192-47b3-a46d-6ec3a7f88664") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("43dfcbd5-f4ac-44bc-a801-660061e53125"), new Guid("890985c5-b423-4fd4-bf40-91aa9bd2e5dc") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("43dfcbd5-f4ac-44bc-a801-660061e53125"), new Guid("9507c750-c643-47a7-90d3-46633c16c237") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("43dfcbd5-f4ac-44bc-a801-660061e53125"), new Guid("d416b04b-83b2-4f36-83bf-5b7fa817ee2c") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("43dfcbd5-f4ac-44bc-a801-660061e53125"), new Guid("e9c19fff-b42b-49d1-8309-02ae412a60de") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("4eb39313-02a6-4139-93e5-b39609fc4167"), new Guid("233091f1-0bc4-402f-aca0-a64e057322f8") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("4eb39313-02a6-4139-93e5-b39609fc4167"), new Guid("6df13233-ad61-45ff-942b-1857da99c0f1") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("4eb39313-02a6-4139-93e5-b39609fc4167"), new Guid("958fa84a-469b-42c3-a6f2-9ee4276b2e40") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("4eb39313-02a6-4139-93e5-b39609fc4167"), new Guid("9a608f65-9834-47d9-85ce-2818907b0a3b") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("4eb39313-02a6-4139-93e5-b39609fc4167"), new Guid("b659c2e0-f7e9-4258-a628-1e108831ddf0") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("4eb39313-02a6-4139-93e5-b39609fc4167"), new Guid("bc289b4d-20e1-4696-a55f-ac9023161b31") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("500dc1df-9607-4e2a-8a23-e138692382c5"), new Guid("545a3223-1a97-43a2-ae74-60ff4dd2b7ec") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("500dc1df-9607-4e2a-8a23-e138692382c5"), new Guid("6dc7eabd-f824-457f-a738-9bac58b5604b") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("500dc1df-9607-4e2a-8a23-e138692382c5"), new Guid("958fa84a-469b-42c3-a6f2-9ee4276b2e40") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("500dc1df-9607-4e2a-8a23-e138692382c5"), new Guid("cbbc812e-3cab-42b9-aeca-f91cf21194c1") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("500dc1df-9607-4e2a-8a23-e138692382c5"), new Guid("d416b04b-83b2-4f36-83bf-5b7fa817ee2c") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("500dc1df-9607-4e2a-8a23-e138692382c5"), new Guid("e9c19fff-b42b-49d1-8309-02ae412a60de") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("578a9540-9f86-48f7-8dea-ab1db8033422"), new Guid("2a8f120d-fb1c-4cf8-8f2b-65179bfe59fc") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("578a9540-9f86-48f7-8dea-ab1db8033422"), new Guid("545a3223-1a97-43a2-ae74-60ff4dd2b7ec") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("578a9540-9f86-48f7-8dea-ab1db8033422"), new Guid("cbbc812e-3cab-42b9-aeca-f91cf21194c1") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("578a9540-9f86-48f7-8dea-ab1db8033422"), new Guid("d416b04b-83b2-4f36-83bf-5b7fa817ee2c") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("578a9540-9f86-48f7-8dea-ab1db8033422"), new Guid("e9c19fff-b42b-49d1-8309-02ae412a60de") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("578a9540-9f86-48f7-8dea-ab1db8033422"), new Guid("ecf04aee-4f83-4631-998d-f398684a1824") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("595ca34e-fa75-4c0e-b730-62c19cd36fea"), new Guid("87c3dfd2-eb9c-474c-bc20-d2586eff3fe2") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("595ca34e-fa75-4c0e-b730-62c19cd36fea"), new Guid("a48f9a90-f6a0-4f83-9750-b1ab9540a901") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("595ca34e-fa75-4c0e-b730-62c19cd36fea"), new Guid("a69946bc-acb4-4f7d-9eb0-7ed4f0ebac40") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("595ca34e-fa75-4c0e-b730-62c19cd36fea"), new Guid("cbbc812e-3cab-42b9-aeca-f91cf21194c1") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("595ca34e-fa75-4c0e-b730-62c19cd36fea"), new Guid("cc857f6e-0f23-481a-8a21-19164e6414f1") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("5dc91c8c-a8eb-4d04-8ca0-3de007d17cdc"), new Guid("13c0cc5f-ad64-40bc-90b7-502e92e3d5c0") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("5dc91c8c-a8eb-4d04-8ca0-3de007d17cdc"), new Guid("3a06d804-0635-4cd0-81ca-4dbcab0e5c40") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("5dc91c8c-a8eb-4d04-8ca0-3de007d17cdc"), new Guid("890985c5-b423-4fd4-bf40-91aa9bd2e5dc") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("5dc91c8c-a8eb-4d04-8ca0-3de007d17cdc"), new Guid("e9052ff3-f1fa-4792-ab3f-5a25b3686031") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("5ef9d6b1-47bd-4887-bfd2-e130f3f29cdc"), new Guid("8bb5da12-bd2f-4357-bfd3-7628ff23ac81") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("5ef9d6b1-47bd-4887-bfd2-e130f3f29cdc"), new Guid("958fa84a-469b-42c3-a6f2-9ee4276b2e40") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("5ef9d6b1-47bd-4887-bfd2-e130f3f29cdc"), new Guid("aacd600b-0eeb-4a52-b147-0f209549885f") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("5ef9d6b1-47bd-4887-bfd2-e130f3f29cdc"), new Guid("e9c19fff-b42b-49d1-8309-02ae412a60de") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("6058a82e-c1dc-414c-90c3-200a97944b8d"), new Guid("23e31995-07e9-4ef1-a79c-297d29e5c8dd") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("6058a82e-c1dc-414c-90c3-200a97944b8d"), new Guid("2a8f120d-fb1c-4cf8-8f2b-65179bfe59fc") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("6058a82e-c1dc-414c-90c3-200a97944b8d"), new Guid("545a3223-1a97-43a2-ae74-60ff4dd2b7ec") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("6058a82e-c1dc-414c-90c3-200a97944b8d"), new Guid("aacd600b-0eeb-4a52-b147-0f209549885f") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("6058a82e-c1dc-414c-90c3-200a97944b8d"), new Guid("cbbc812e-3cab-42b9-aeca-f91cf21194c1") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("6058a82e-c1dc-414c-90c3-200a97944b8d"), new Guid("d416b04b-83b2-4f36-83bf-5b7fa817ee2c") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("6058a82e-c1dc-414c-90c3-200a97944b8d"), new Guid("e9c19fff-b42b-49d1-8309-02ae412a60de") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("62673a98-212a-4086-81b8-c81c6d3d4dc1"), new Guid("890985c5-b423-4fd4-bf40-91aa9bd2e5dc") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("62673a98-212a-4086-81b8-c81c6d3d4dc1"), new Guid("958fa84a-469b-42c3-a6f2-9ee4276b2e40") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("62673a98-212a-4086-81b8-c81c6d3d4dc1"), new Guid("9cb56da2-a1a1-4f5a-bf76-5392d0a9b049") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("62673a98-212a-4086-81b8-c81c6d3d4dc1"), new Guid("a6ce6fc1-ebf4-4286-80da-fccf5aa60266") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("62673a98-212a-4086-81b8-c81c6d3d4dc1"), new Guid("cf0def79-5b99-4754-a775-b76f14f3bbe4") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("62bcbadc-1b42-437f-9a13-3f52d76123aa"), new Guid("19ccee14-002c-4bd0-a205-caa0c6acbe36") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("62bcbadc-1b42-437f-9a13-3f52d76123aa"), new Guid("3d5838f2-4fff-4350-8de1-b6041ef68c9a") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("62bcbadc-1b42-437f-9a13-3f52d76123aa"), new Guid("48d069a2-9c39-4665-9485-22e4b56a7972") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("62bcbadc-1b42-437f-9a13-3f52d76123aa"), new Guid("96bd77d3-3448-4fb8-88ff-80eed4e40737") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("62bcbadc-1b42-437f-9a13-3f52d76123aa"), new Guid("aacd600b-0eeb-4a52-b147-0f209549885f") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("62bcbadc-1b42-437f-9a13-3f52d76123aa"), new Guid("cbbc812e-3cab-42b9-aeca-f91cf21194c1") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("62bcbadc-1b42-437f-9a13-3f52d76123aa"), new Guid("e9c19fff-b42b-49d1-8309-02ae412a60de") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("7f411aa8-26af-48f8-8b69-5e7025b4a935"), new Guid("2a8f120d-fb1c-4cf8-8f2b-65179bfe59fc") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("7f411aa8-26af-48f8-8b69-5e7025b4a935"), new Guid("545a3223-1a97-43a2-ae74-60ff4dd2b7ec") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("7f411aa8-26af-48f8-8b69-5e7025b4a935"), new Guid("cbbc812e-3cab-42b9-aeca-f91cf21194c1") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("7f411aa8-26af-48f8-8b69-5e7025b4a935"), new Guid("d416b04b-83b2-4f36-83bf-5b7fa817ee2c") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("7f411aa8-26af-48f8-8b69-5e7025b4a935"), new Guid("e9c19fff-b42b-49d1-8309-02ae412a60de") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("7f411aa8-26af-48f8-8b69-5e7025b4a935"), new Guid("ecf04aee-4f83-4631-998d-f398684a1824") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("8356106d-f708-48fb-9499-cf0dd3b677c5"), new Guid("639f0d3d-61b8-4d41-95e2-c948ce30171d") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("8356106d-f708-48fb-9499-cf0dd3b677c5"), new Guid("958fa84a-469b-42c3-a6f2-9ee4276b2e40") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("8356106d-f708-48fb-9499-cf0dd3b677c5"), new Guid("a48f9a90-f6a0-4f83-9750-b1ab9540a901") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("8356106d-f708-48fb-9499-cf0dd3b677c5"), new Guid("a69946bc-acb4-4f7d-9eb0-7ed4f0ebac40") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("8356106d-f708-48fb-9499-cf0dd3b677c5"), new Guid("d416b04b-83b2-4f36-83bf-5b7fa817ee2c") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("8356106d-f708-48fb-9499-cf0dd3b677c5"), new Guid("e9c19fff-b42b-49d1-8309-02ae412a60de") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("85602a47-13d3-4bc0-874e-3dcb5066a4b5"), new Guid("4acaf4bd-8b6c-4f99-aa82-9baaa28a0740") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("85602a47-13d3-4bc0-874e-3dcb5066a4b5"), new Guid("a01dd380-0986-4b18-8e90-523f64fe815b") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("85602a47-13d3-4bc0-874e-3dcb5066a4b5"), new Guid("b7cc1c6f-ca92-4c00-b899-cdc0aba0590b") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("89db9df9-b7aa-44da-a446-a240e64d4b5c"), new Guid("2a8f120d-fb1c-4cf8-8f2b-65179bfe59fc") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("89db9df9-b7aa-44da-a446-a240e64d4b5c"), new Guid("545a3223-1a97-43a2-ae74-60ff4dd2b7ec") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("89db9df9-b7aa-44da-a446-a240e64d4b5c"), new Guid("cbbc812e-3cab-42b9-aeca-f91cf21194c1") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("89db9df9-b7aa-44da-a446-a240e64d4b5c"), new Guid("d416b04b-83b2-4f36-83bf-5b7fa817ee2c") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("89db9df9-b7aa-44da-a446-a240e64d4b5c"), new Guid("e9c19fff-b42b-49d1-8309-02ae412a60de") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("89db9df9-b7aa-44da-a446-a240e64d4b5c"), new Guid("ecf04aee-4f83-4631-998d-f398684a1824") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("8feb1de4-7011-4939-8ea1-25927280d0dd"), new Guid("62025c26-33c8-47b1-919c-acb4191e3280") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("8feb1de4-7011-4939-8ea1-25927280d0dd"), new Guid("6dc7eabd-f824-457f-a738-9bac58b5604b") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("8feb1de4-7011-4939-8ea1-25927280d0dd"), new Guid("8da99e93-ba60-40de-89f0-9032e0a5631b") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("8feb1de4-7011-4939-8ea1-25927280d0dd"), new Guid("958fa84a-469b-42c3-a6f2-9ee4276b2e40") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("8feb1de4-7011-4939-8ea1-25927280d0dd"), new Guid("9a608f65-9834-47d9-85ce-2818907b0a3b") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("8feb1de4-7011-4939-8ea1-25927280d0dd"), new Guid("aacd600b-0eeb-4a52-b147-0f209549885f") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("8feb1de4-7011-4939-8ea1-25927280d0dd"), new Guid("cbbc812e-3cab-42b9-aeca-f91cf21194c1") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("8feb1de4-7011-4939-8ea1-25927280d0dd"), new Guid("e9c19fff-b42b-49d1-8309-02ae412a60de") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("96c7a4ef-43d0-4d89-a3c9-5a3974f36533"), new Guid("3c85333d-03ce-4eea-b8f1-273a24cad04b") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("96c7a4ef-43d0-4d89-a3c9-5a3974f36533"), new Guid("545a3223-1a97-43a2-ae74-60ff4dd2b7ec") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("96c7a4ef-43d0-4d89-a3c9-5a3974f36533"), new Guid("9a608f65-9834-47d9-85ce-2818907b0a3b") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("96c7a4ef-43d0-4d89-a3c9-5a3974f36533"), new Guid("a48f9a90-f6a0-4f83-9750-b1ab9540a901") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("96c7a4ef-43d0-4d89-a3c9-5a3974f36533"), new Guid("a8fd4501-4100-497b-8a17-8ddba4fd7886") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("96c7a4ef-43d0-4d89-a3c9-5a3974f36533"), new Guid("ac00b15c-a093-483a-bc71-76f18843c2dc") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("96c7a4ef-43d0-4d89-a3c9-5a3974f36533"), new Guid("cc857f6e-0f23-481a-8a21-19164e6414f1") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("9a848840-6c03-4df8-bfb4-1122c8400c06"), new Guid("3c85333d-03ce-4eea-b8f1-273a24cad04b") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("9a848840-6c03-4df8-bfb4-1122c8400c06"), new Guid("545a3223-1a97-43a2-ae74-60ff4dd2b7ec") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("9a848840-6c03-4df8-bfb4-1122c8400c06"), new Guid("9a608f65-9834-47d9-85ce-2818907b0a3b") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("9a848840-6c03-4df8-bfb4-1122c8400c06"), new Guid("a48f9a90-f6a0-4f83-9750-b1ab9540a901") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("9a848840-6c03-4df8-bfb4-1122c8400c06"), new Guid("a8fd4501-4100-497b-8a17-8ddba4fd7886") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("9b15c06c-b07b-47c6-a95c-af95825180b3"), new Guid("87c3dfd2-eb9c-474c-bc20-d2586eff3fe2") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("9b15c06c-b07b-47c6-a95c-af95825180b3"), new Guid("8da99e93-ba60-40de-89f0-9032e0a5631b") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("9b15c06c-b07b-47c6-a95c-af95825180b3"), new Guid("8debb346-fef6-44d3-baa8-37a0a12291a0") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("9b15c06c-b07b-47c6-a95c-af95825180b3"), new Guid("9a608f65-9834-47d9-85ce-2818907b0a3b") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("9b15c06c-b07b-47c6-a95c-af95825180b3"), new Guid("a7f9abec-e209-4a5c-99e3-bdb3a679a2f7") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("9b15c06c-b07b-47c6-a95c-af95825180b3"), new Guid("aacd600b-0eeb-4a52-b147-0f209549885f") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("9b15c06c-b07b-47c6-a95c-af95825180b3"), new Guid("cbbc812e-3cab-42b9-aeca-f91cf21194c1") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("9b15c06c-b07b-47c6-a95c-af95825180b3"), new Guid("e9c19fff-b42b-49d1-8309-02ae412a60de") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("a2bdc0c4-fea7-4e66-90dc-a5d068c854b9"), new Guid("545a3223-1a97-43a2-ae74-60ff4dd2b7ec") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("a2bdc0c4-fea7-4e66-90dc-a5d068c854b9"), new Guid("dc31bb70-1d06-4b28-9ba8-308a56ee9209") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("a2bdc0c4-fea7-4e66-90dc-a5d068c854b9"), new Guid("dc97a1f5-a068-4ea9-8513-84564acac4c1") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("a2bdc0c4-fea7-4e66-90dc-a5d068c854b9"), new Guid("e9c19fff-b42b-49d1-8309-02ae412a60de") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("a2bdc0c4-fea7-4e66-90dc-a5d068c854b9"), new Guid("ecf04aee-4f83-4631-998d-f398684a1824") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("a4efa4f5-19f6-43da-8710-34e12656dd36"), new Guid("545a3223-1a97-43a2-ae74-60ff4dd2b7ec") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("a4efa4f5-19f6-43da-8710-34e12656dd36"), new Guid("8da99e93-ba60-40de-89f0-9032e0a5631b") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("a4efa4f5-19f6-43da-8710-34e12656dd36"), new Guid("a7f9abec-e209-4a5c-99e3-bdb3a679a2f7") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("a4efa4f5-19f6-43da-8710-34e12656dd36"), new Guid("cbbc812e-3cab-42b9-aeca-f91cf21194c1") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("a4efa4f5-19f6-43da-8710-34e12656dd36"), new Guid("cd0ada9b-9c35-45ed-b7fc-14079c01ffa7") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("a8369011-960d-41e1-ab81-111106be561e"), new Guid("13c0cc5f-ad64-40bc-90b7-502e92e3d5c0") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("a8369011-960d-41e1-ab81-111106be561e"), new Guid("233091f1-0bc4-402f-aca0-a64e057322f8") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("a8369011-960d-41e1-ab81-111106be561e"), new Guid("4e4e0759-c9b0-47e7-9782-99a8e1cd601e") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("a8369011-960d-41e1-ab81-111106be561e"), new Guid("5391b3cc-31be-4ed7-906b-969a08e11ac3") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("a8369011-960d-41e1-ab81-111106be561e"), new Guid("87c3dfd2-eb9c-474c-bc20-d2586eff3fe2") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("a8369011-960d-41e1-ab81-111106be561e"), new Guid("9a608f65-9834-47d9-85ce-2818907b0a3b") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("a8369011-960d-41e1-ab81-111106be561e"), new Guid("b5afce52-fa3f-4edd-825f-ed59412143cf") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("a8369011-960d-41e1-ab81-111106be561e"), new Guid("b659c2e0-f7e9-4258-a628-1e108831ddf0") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("a8369011-960d-41e1-ab81-111106be561e"), new Guid("bc289b4d-20e1-4696-a55f-ac9023161b31") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("b59efa1b-9b14-4313-bf8a-18088bc3ad8c"), new Guid("2d6c9fcb-a933-4912-a16c-4ad290777cb8") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("b59efa1b-9b14-4313-bf8a-18088bc3ad8c"), new Guid("3d5838f2-4fff-4350-8de1-b6041ef68c9a") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("b59efa1b-9b14-4313-bf8a-18088bc3ad8c"), new Guid("545a3223-1a97-43a2-ae74-60ff4dd2b7ec") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("b59efa1b-9b14-4313-bf8a-18088bc3ad8c"), new Guid("9cb56da2-a1a1-4f5a-bf76-5392d0a9b049") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("b59efa1b-9b14-4313-bf8a-18088bc3ad8c"), new Guid("cbbc812e-3cab-42b9-aeca-f91cf21194c1") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("b82d52f2-4512-4ff0-a8e5-2ddcfe3bd2d6"), new Guid("344c0405-f0b9-408e-ae56-063bfa06d705") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("b82d52f2-4512-4ff0-a8e5-2ddcfe3bd2d6"), new Guid("a48f9a90-f6a0-4f83-9750-b1ab9540a901") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("b82d52f2-4512-4ff0-a8e5-2ddcfe3bd2d6"), new Guid("aacd600b-0eeb-4a52-b147-0f209549885f") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("b82d52f2-4512-4ff0-a8e5-2ddcfe3bd2d6"), new Guid("b22ec78a-cfb1-4278-905d-857b79f7fa0b") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("b82d52f2-4512-4ff0-a8e5-2ddcfe3bd2d6"), new Guid("cbbc812e-3cab-42b9-aeca-f91cf21194c1") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("b82d52f2-4512-4ff0-a8e5-2ddcfe3bd2d6"), new Guid("e9c19fff-b42b-49d1-8309-02ae412a60de") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("c2b77138-6689-49cc-9d79-39389c20cee2"), new Guid("37b9e987-6a33-4514-a6d2-835903743369") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("c2b77138-6689-49cc-9d79-39389c20cee2"), new Guid("a8fd4501-4100-497b-8a17-8ddba4fd7886") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("c2b77138-6689-49cc-9d79-39389c20cee2"), new Guid("cbbc812e-3cab-42b9-aeca-f91cf21194c1") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("d23dba1f-e4ff-4392-aa3b-3a0d2a163cf5"), new Guid("545a3223-1a97-43a2-ae74-60ff4dd2b7ec") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("d23dba1f-e4ff-4392-aa3b-3a0d2a163cf5"), new Guid("8debb346-fef6-44d3-baa8-37a0a12291a0") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("d23dba1f-e4ff-4392-aa3b-3a0d2a163cf5"), new Guid("9e7303bc-730a-4d5c-a110-57029ffd7ff4") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("d23dba1f-e4ff-4392-aa3b-3a0d2a163cf5"), new Guid("a7f9abec-e209-4a5c-99e3-bdb3a679a2f7") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("d23dba1f-e4ff-4392-aa3b-3a0d2a163cf5"), new Guid("aacd600b-0eeb-4a52-b147-0f209549885f") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("d23dba1f-e4ff-4392-aa3b-3a0d2a163cf5"), new Guid("e9c19fff-b42b-49d1-8309-02ae412a60de") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("ea94b18d-7c05-4e13-93ab-ab448452991e"), new Guid("12abccf4-937a-48b4-8cfc-eacdc2eb4358") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("ea94b18d-7c05-4e13-93ab-ab448452991e"), new Guid("233091f1-0bc4-402f-aca0-a64e057322f8") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("ea94b18d-7c05-4e13-93ab-ab448452991e"), new Guid("958fa84a-469b-42c3-a6f2-9ee4276b2e40") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("ea94b18d-7c05-4e13-93ab-ab448452991e"), new Guid("9a608f65-9834-47d9-85ce-2818907b0a3b") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("ea94b18d-7c05-4e13-93ab-ab448452991e"), new Guid("aacd600b-0eeb-4a52-b147-0f209549885f") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("ea94b18d-7c05-4e13-93ab-ab448452991e"), new Guid("aba5e721-d45c-4da5-b9f7-6dab5bab3298") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("ea94b18d-7c05-4e13-93ab-ab448452991e"), new Guid("b659c2e0-f7e9-4258-a628-1e108831ddf0") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("ea94b18d-7c05-4e13-93ab-ab448452991e"), new Guid("bc289b4d-20e1-4696-a55f-ac9023161b31") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("ea94b18d-7c05-4e13-93ab-ab448452991e"), new Guid("e9c19fff-b42b-49d1-8309-02ae412a60de") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("fc13c569-da0c-4f19-bba0-f1491850d3d4"), new Guid("545a3223-1a97-43a2-ae74-60ff4dd2b7ec") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("fc13c569-da0c-4f19-bba0-f1491850d3d4"), new Guid("8debb346-fef6-44d3-baa8-37a0a12291a0") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("fc13c569-da0c-4f19-bba0-f1491850d3d4"), new Guid("9a608f65-9834-47d9-85ce-2818907b0a3b") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("fc13c569-da0c-4f19-bba0-f1491850d3d4"), new Guid("aacd600b-0eeb-4a52-b147-0f209549885f") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("fc13c569-da0c-4f19-bba0-f1491850d3d4"), new Guid("b659c2e0-f7e9-4258-a628-1e108831ddf0") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("fc13c569-da0c-4f19-bba0-f1491850d3d4"), new Guid("e1683932-78a2-4ded-a23b-7729573aceca") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("fc13c569-da0c-4f19-bba0-f1491850d3d4"), new Guid("e9c19fff-b42b-49d1-8309-02ae412a60de") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("fc13c569-da0c-4f19-bba0-f1491850d3d4"), new Guid("f0d0e2f7-f03c-46df-8a6a-4e94cf4dce55") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("fe7a07aa-7456-481a-971d-fcc0a65fb34e"), new Guid("87c3dfd2-eb9c-474c-bc20-d2586eff3fe2") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("fe7a07aa-7456-481a-971d-fcc0a65fb34e"), new Guid("9a608f65-9834-47d9-85ce-2818907b0a3b") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("fe7a07aa-7456-481a-971d-fcc0a65fb34e"), new Guid("9be2b66e-aacd-4110-b937-87e7de68aae9") });

            migrationBuilder.DeleteData(
                table: "LinkTags",
                keyColumns: new[] { "LinkId", "TagId" },
                keyValues: new object[] { new Guid("fe7a07aa-7456-481a-971d-fcc0a65fb34e"), new Guid("aacd600b-0eeb-4a52-b147-0f209549885f") });

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("09c743bf-7461-4f43-a671-9966d03b9d0c"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("0e3ce281-5d28-40f5-b34e-43ff5dc07b16"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("233a88ca-3452-4b7b-89d3-efb6fe405316"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("28c18b22-4699-4df3-8ac5-b76b13f3cd1b"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("3169bb2b-b752-4a1a-bdcb-294c8a080979"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("40b4e33f-1859-45fe-b6c7-7ee7eac6e337"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("63bd4a10-d00f-4d3e-a913-c2b1eb00ca1c"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("7319b1f7-e0ef-49b7-9cc2-b73c3e79f5eb"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("8606f298-1d23-4001-9115-cb487dd96e77"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("90e3d0f5-0487-467d-aee2-478378bff623"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("9cfce7ee-c57a-476c-86fd-fd87a13dd573"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("a39d1527-8d4f-4ff8-bcbf-c3458de5588e"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("ac585b09-b9a3-438f-8f8e-73b9f16fe597"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("b7bb539f-fa0e-4234-8f67-32a03b43e5f7"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("bd2bbdb1-379d-4fdc-b7bb-27b2a1770c4c"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("cfba8acf-e9fb-4a5b-aaff-383636379268"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("d41b6b30-ecd0-4a5d-bd45-4ecabd20011b"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("df91bd45-cc8c-458f-9079-b20b65ec5caf"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("e3df4bb9-eda1-4896-a72b-1ecb66b55779"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("f8a509cd-c12e-4122-ba76-1735d36facee"));

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "Id",
                keyValue: new Guid("0b7ad369-255a-418e-85f0-ea9efcdbb04d"));

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "Id",
                keyValue: new Guid("0ce04084-dcb1-4250-8d7c-a73385cbb76d"));

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "Id",
                keyValue: new Guid("0eba1889-edc2-48c1-a5eb-45fc773e192c"));

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "Id",
                keyValue: new Guid("10ef6655-5cfb-40d3-b4ea-138fdd9ffd77"));

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "Id",
                keyValue: new Guid("145da347-783c-4fec-b163-ec4c76b306c2"));

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "Id",
                keyValue: new Guid("1921a6cb-7ef9-47ba-ba7c-0bc7f47d028c"));

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "Id",
                keyValue: new Guid("1a627430-6cef-4a81-88f2-79ee9adfcb12"));

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "Id",
                keyValue: new Guid("1ccf53a1-ceb8-43cd-beb1-27efbdc8f25e"));

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "Id",
                keyValue: new Guid("1e792fe6-ab89-418e-8456-cfa05a433d25"));

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "Id",
                keyValue: new Guid("305ccacd-ed90-481e-8f8e-b28ce910cb97"));

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "Id",
                keyValue: new Guid("3334b097-20a9-453f-9ef7-919432abeb64"));

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "Id",
                keyValue: new Guid("35af062d-cdee-4bf2-8d10-3b2a4d5d35a4"));

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "Id",
                keyValue: new Guid("39e90802-df2e-4f05-8bf0-ec3cda2782a5"));

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "Id",
                keyValue: new Guid("4190e202-1477-40a2-935a-d85ba55d713a"));

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "Id",
                keyValue: new Guid("4267f54f-70c8-4fa6-9f79-e6c7ffd35ef7"));

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "Id",
                keyValue: new Guid("43dfcbd5-f4ac-44bc-a801-660061e53125"));

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "Id",
                keyValue: new Guid("4eb39313-02a6-4139-93e5-b39609fc4167"));

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "Id",
                keyValue: new Guid("500dc1df-9607-4e2a-8a23-e138692382c5"));

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "Id",
                keyValue: new Guid("578a9540-9f86-48f7-8dea-ab1db8033422"));

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "Id",
                keyValue: new Guid("595ca34e-fa75-4c0e-b730-62c19cd36fea"));

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "Id",
                keyValue: new Guid("5dc91c8c-a8eb-4d04-8ca0-3de007d17cdc"));

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "Id",
                keyValue: new Guid("5ef9d6b1-47bd-4887-bfd2-e130f3f29cdc"));

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "Id",
                keyValue: new Guid("6058a82e-c1dc-414c-90c3-200a97944b8d"));

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "Id",
                keyValue: new Guid("62673a98-212a-4086-81b8-c81c6d3d4dc1"));

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "Id",
                keyValue: new Guid("62bcbadc-1b42-437f-9a13-3f52d76123aa"));

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "Id",
                keyValue: new Guid("7f411aa8-26af-48f8-8b69-5e7025b4a935"));

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "Id",
                keyValue: new Guid("8356106d-f708-48fb-9499-cf0dd3b677c5"));

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "Id",
                keyValue: new Guid("85602a47-13d3-4bc0-874e-3dcb5066a4b5"));

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "Id",
                keyValue: new Guid("89db9df9-b7aa-44da-a446-a240e64d4b5c"));

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "Id",
                keyValue: new Guid("8feb1de4-7011-4939-8ea1-25927280d0dd"));

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "Id",
                keyValue: new Guid("96c7a4ef-43d0-4d89-a3c9-5a3974f36533"));

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "Id",
                keyValue: new Guid("9a848840-6c03-4df8-bfb4-1122c8400c06"));

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "Id",
                keyValue: new Guid("9b15c06c-b07b-47c6-a95c-af95825180b3"));

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "Id",
                keyValue: new Guid("a2bdc0c4-fea7-4e66-90dc-a5d068c854b9"));

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "Id",
                keyValue: new Guid("a4efa4f5-19f6-43da-8710-34e12656dd36"));

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "Id",
                keyValue: new Guid("a8369011-960d-41e1-ab81-111106be561e"));

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "Id",
                keyValue: new Guid("b59efa1b-9b14-4313-bf8a-18088bc3ad8c"));

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "Id",
                keyValue: new Guid("b82d52f2-4512-4ff0-a8e5-2ddcfe3bd2d6"));

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "Id",
                keyValue: new Guid("c2b77138-6689-49cc-9d79-39389c20cee2"));

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "Id",
                keyValue: new Guid("d23dba1f-e4ff-4392-aa3b-3a0d2a163cf5"));

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "Id",
                keyValue: new Guid("ea94b18d-7c05-4e13-93ab-ab448452991e"));

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "Id",
                keyValue: new Guid("fc13c569-da0c-4f19-bba0-f1491850d3d4"));

            migrationBuilder.DeleteData(
                table: "Links",
                keyColumn: "Id",
                keyValue: new Guid("fe7a07aa-7456-481a-971d-fcc0a65fb34e"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("021fcffe-e6d7-4f68-810b-2330116331b3"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("12abccf4-937a-48b4-8cfc-eacdc2eb4358"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("13c0cc5f-ad64-40bc-90b7-502e92e3d5c0"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("19ccee14-002c-4bd0-a205-caa0c6acbe36"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("233091f1-0bc4-402f-aca0-a64e057322f8"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("23e31995-07e9-4ef1-a79c-297d29e5c8dd"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("244c117c-e184-473b-9131-02fc45d1b4e5"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("2a8f120d-fb1c-4cf8-8f2b-65179bfe59fc"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("2d6c9fcb-a933-4912-a16c-4ad290777cb8"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("344c0405-f0b9-408e-ae56-063bfa06d705"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("37b9e987-6a33-4514-a6d2-835903743369"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("381184be-55af-4f55-9fd5-94a5c5864582"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("382167e3-7ce7-4422-8c80-e4b2c18934c0"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("3a06d804-0635-4cd0-81ca-4dbcab0e5c40"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("3c85333d-03ce-4eea-b8f1-273a24cad04b"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("3d5838f2-4fff-4350-8de1-b6041ef68c9a"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("40f84a57-8260-47c3-8e53-55f5c67719c6"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("45e34501-421a-4ba3-85d2-b07eb71c3f5c"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("48d069a2-9c39-4665-9485-22e4b56a7972"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("4acaf4bd-8b6c-4f99-aa82-9baaa28a0740"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("4e4e0759-c9b0-47e7-9782-99a8e1cd601e"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("5391b3cc-31be-4ed7-906b-969a08e11ac3"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("545a3223-1a97-43a2-ae74-60ff4dd2b7ec"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("55e88610-b070-42aa-8c99-533b2b881b05"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("61d18801-8587-4763-862d-1dc0c69d831a"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("62025c26-33c8-47b1-919c-acb4191e3280"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("639f0d3d-61b8-4d41-95e2-c948ce30171d"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("6dc7eabd-f824-457f-a738-9bac58b5604b"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("6df13233-ad61-45ff-942b-1857da99c0f1"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("7a59d506-1192-47b3-a46d-6ec3a7f88664"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("87c3dfd2-eb9c-474c-bc20-d2586eff3fe2"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("890985c5-b423-4fd4-bf40-91aa9bd2e5dc"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("8bb5da12-bd2f-4357-bfd3-7628ff23ac81"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("8da99e93-ba60-40de-89f0-9032e0a5631b"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("8debb346-fef6-44d3-baa8-37a0a12291a0"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("9507c750-c643-47a7-90d3-46633c16c237"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("958fa84a-469b-42c3-a6f2-9ee4276b2e40"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("96bd77d3-3448-4fb8-88ff-80eed4e40737"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("9a608f65-9834-47d9-85ce-2818907b0a3b"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("9be2b66e-aacd-4110-b937-87e7de68aae9"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("9cb56da2-a1a1-4f5a-bf76-5392d0a9b049"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("9e7303bc-730a-4d5c-a110-57029ffd7ff4"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("a01dd380-0986-4b18-8e90-523f64fe815b"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("a48f9a90-f6a0-4f83-9750-b1ab9540a901"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("a69946bc-acb4-4f7d-9eb0-7ed4f0ebac40"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("a6ce6fc1-ebf4-4286-80da-fccf5aa60266"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("a7f9abec-e209-4a5c-99e3-bdb3a679a2f7"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("a8fd4501-4100-497b-8a17-8ddba4fd7886"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("aacd600b-0eeb-4a52-b147-0f209549885f"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("aba5e721-d45c-4da5-b9f7-6dab5bab3298"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("ac00b15c-a093-483a-bc71-76f18843c2dc"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("b22ec78a-cfb1-4278-905d-857b79f7fa0b"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("b5afce52-fa3f-4edd-825f-ed59412143cf"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("b659c2e0-f7e9-4258-a628-1e108831ddf0"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("b7cc1c6f-ca92-4c00-b899-cdc0aba0590b"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("bc289b4d-20e1-4696-a55f-ac9023161b31"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("cbbc812e-3cab-42b9-aeca-f91cf21194c1"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("cc857f6e-0f23-481a-8a21-19164e6414f1"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("cd0ada9b-9c35-45ed-b7fc-14079c01ffa7"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("cf0def79-5b99-4754-a775-b76f14f3bbe4"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("d416b04b-83b2-4f36-83bf-5b7fa817ee2c"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("dc31bb70-1d06-4b28-9ba8-308a56ee9209"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("dc97a1f5-a068-4ea9-8513-84564acac4c1"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("e1683932-78a2-4ded-a23b-7729573aceca"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("e9052ff3-f1fa-4792-ab3f-5a25b3686031"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("e9c19fff-b42b-49d1-8309-02ae412a60de"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("ecf04aee-4f83-4631-998d-f398684a1824"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("f0d0e2f7-f03c-46df-8a6a-4e94cf4dce55"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("fcc2ef68-57e6-4114-ad5f-cf3fb81e89a0"));
        }
    }
}
