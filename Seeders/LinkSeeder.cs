using System;

using Microsoft.EntityFrameworkCore;

using OhanaSupport.Models;
using OhanaSupport.Enumerators;

namespace OhanaSupport.Seeders {
    public class LinkSeeder {
        public void Seed(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Link>().HasData(
                new Link { //
                    Id = Guid.Parse("6058a82e-c1dc-414c-90c3-200a97944b8d"),
                    Url = "https://www.zerotothree.org/resources/3211-why-are-people-wearing-masks-why-are-people-covering-their-faces",
                    Name = "Why are people wearing masks? Why are people covering their faces?",
                    Description = "Talking to children about the use of masks and talking to children about covid 19 ",
                    Origin = "zerotothree",
                    Published = null,
                    Type = LinkType.Website,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null
                },
                new Link { //
                    Id = Guid.Parse("500dc1df-9607-4e2a-8a23-e138692382c5"),
                    Url = "https://humanservices.hawaii.gov/wp-content/uploads/2020/05/Guidelines-for-Child-Care-Facilities-2020-05-19-final.pdf",
                    Name = "Guidelines for Child Care Facilities to Reopen or Continue Care",
                    Description = "A checklist or guideline to follow for childcare facilities to reopen or continue care.",
                    Origin = "Human Services",
                    Published = DateTime.Parse("05/19/2020"),
                    Type = LinkType.Document,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null
                },
                new Link { //
                    Id = Guid.Parse("89db9df9-b7aa-44da-a446-a240e64d4b5c"),
                    Url = "https://www.fatherly.com/health-science/daycare-coronavirus-safety-health/",
                    Name = "Is it time to send your kid back to daycare",
                    Description = "An article avocating the pros and cons of sending your child back to daycare.",
                    Origin = "Fatherly",
                    Published = DateTime.Parse("05/14/2020"),
                    Type = LinkType.Website,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null
                },
                new Link { //
                    Id = Guid.Parse("c2b77138-6689-49cc-9d79-39389c20cee2"),
                    Url = "https://sites.google.com/eoel.hawaii.gov/covid-19/home?authuser=0", 
                    Name = "COVID19 Resources and Info",
                    Description = "Covid 19 recources for families with young kids that need help with child care, daycare, and as well as donations. For Child providers it is a place to bring recources together for providers ",
                    Origin = "Executive Office on Early Learning, State of Hawaii",
                    Published = null,
                    Type = LinkType.Website,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null
                },
                new Link {//
                    Id = Guid.Parse("4267f54f-70c8-4fa6-9f79-e6c7ffd35ef7"),
                    Url = " https://www.cdc.gov/coronavirus/2019-nCoV/index.html",
                    Name = "Learn more about the novel coronavirus from the CDC",
                    Description = "The CDC main website explaining the Corona Virus",
                    Origin = "CDC",
                    Published = null,
                    Type = LinkType.Website,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null
                },
                new Link {//
                    Id = Guid.Parse("d23dba1f-e4ff-4392-aa3b-3a0d2a163cf5"),
                    Url = "https://info.teachstone.com/blog/keep-children-engaged-while-at-home-with-a-daily-schedule?utm_campaign=COVID-19&utm_source=hs_email&utm_medium=email&utm_content=85052481&_hsenc=p2ANqtz-_UYrZW7EKyGon7LxbuMktCDHvUCQI0BKU_wHSLtS-s2lB-Y33_R1oXSAma5dH3GT09NfdpeBBLsL-AoZ56eBkOBQ7zqg&_hsmi=85052481",
                    Name = "Use This Daily Schedule to Keep Children at Home Engaged",
                    Description = "Advice for how to plan daily schedules for children and keep them engaged at home.",
                    Origin = "Teachstone",
                    Published = DateTime.Parse("03/18/2020"),
                    Type = LinkType.Website,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null
                },
                new Link {//
                    Id = Guid.Parse("9b15c06c-b07b-47c6-a95c-af95825180b3"),
                    Url = " https://www.zerotothree.org/resources/3264-at-home-activity-guide",
                    Name = "At Home Activities for Infants and Toddlers",
                    Description = "Playing safely with children at home",
                    Origin = "zerotothree",
                    Published = DateTime.Parse("03/16/2020"),
                    Type = LinkType.Website,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null
                },
                new Link {//
                    Id = Guid.Parse("b82d52f2-4512-4ff0-a8e5-2ddcfe3bd2d6"),
                    Url = "https://www.cdc.gov/handwashing/handwashing-family.html", 
                    Name = "Helping Children Develop handwashing skills",
                    Description = "How to help children develop handwashing skills",
                    Origin = "CDC",
                    Published = DateTime.Parse("09/10/2020"),
                    Type = LinkType.Website,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null
                },
                new Link {//
                    Id = Guid.Parse("62673a98-212a-4086-81b8-c81c6d3d4dc1"),
                    Url = "https://docs.google.com/document/d/1u1QkZ0ZMUTFc6tfyzyJTZYoUixCC8H9p5rcQsKCmdHk/edit",
                    Name = "A Thriving Lahui",
                    Description = "Advice for how to plan daily schedules for children and keep them engaged at home.",
                    Origin = "Teachstone",
                    Published = DateTime.Parse("08/21/2020"),
                    Type = LinkType.Document,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null
                },     
                new Link {//
                    Id = Guid.Parse("7f411aa8-26af-48f8-8b69-5e7025b4a935"),
                    Url = "https://www.zerotothree.org/resources/3413-what-comes-next-back-to-child-care-following-shelter-in-place",
                    Name = "What Comes Next: Back to Child Care Following Shelter-in-Place",
                    Description = "Advice on what to do and know before sending your child back to childcare.",
                    Origin = "zerotothree",
                    Published = DateTime.Parse("04/28/2020"),
                    Type = LinkType.Website,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null
                },
                new Link {//
                    Id = Guid.Parse("5dc91c8c-a8eb-4d04-8ca0-3de007d17cdc"),
                    Url = "https://governor.hawaii.gov/emergency-proclamations/",
                    Name = "State of Hawaii Emergency Proclamations",
                    Description = "Emergency proclamations for the state of Hawaii on governor.hawaii.gov",
                    Origin = "State of Hawaii",
                    Published = null,
                    Type = LinkType.Website,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null
                },  
                new Link {//
                    Id = Guid.Parse("145da347-783c-4fec-b163-ec4c76b306c2"),
                    Url = "https://www.hawaiicounty.gov/departments/civil-defense/active-emergency-proclamations",
                    Name = "County of Hawaii Emergency Proclamations",
                    Description = "Emergency proclamations for the county of Hawaii on hawaiicounty.gov",
                    Origin = "Hawaii County",
                    Published = null,
                    Type = LinkType.Website,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null
                },
                new Link {//
                    Id = Guid.Parse("85602a47-13d3-4bc0-874e-3dcb5066a4b5"),
                    Url = "https://www.honolulu.gov/mayor/proclamations-orders-and-rules.html",
                    Name = "City and County of Honolulu Covid 19 Response",
                    Description = "The proclamations, orders, and rules in response to Covid 19 for the City and County of Honolulu.",
                    Origin = "City and County of Honolulu",
                    Published = null,
                    Type = LinkType.Website,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null
                },
                new Link {//
                    Id = Guid.Parse("0b7ad369-255a-418e-85f0-ea9efcdbb04d"),
                    Url = "https://www.kauai.gov/Government/Departments-Agencies/Emergency-Management-Agency-formerly-Civil-Defense/Emergency-Proclamations",
                    Name = "County of Kaua`i Emergency Proclamations",
                    Description = "Emergency Proclamations for the County of Kaua`i.",
                    Origin = "County of Kaua`i",
                    Published = null,
                    Type = LinkType.Website,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null
                },
                new Link {//
                    Id = Guid.Parse("1e792fe6-ab89-418e-8456-cfa05a433d25"),
                    Url = "https://www.mauicounty.gov/2006/Declarations",
                    Name = "County of Maui Emergency Declarations",
                    Description = "Emergency Declarations for the County of Maui.",
                    Origin = "County of Maui",
                    Published = null,
                    Type = LinkType.Website,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null
                },
                new Link {//
                    Id = Guid.Parse("595ca34e-fa75-4c0e-b730-62c19cd36fea"),
                    Url = "https://www.cdc.gov/coronavirus/2019-ncov/downloads/php/CDC-Activities-Initiatives-for-COVID-19-Response.pdf",
                    Name = "CDC Activities and Initiatives Supporting the COVID-19 Response and the President's Plan for Opening America Up Again",
                    Description = "The surveillance and control goals and activities from the CDC to support response to COVID-19.",
                    Origin = "CDC",
                    Published = DateTime.Parse("05/01/2020"),
                    Type = LinkType.Website,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null
                },
                new Link {//
                    Id = Guid.Parse("305ccacd-ed90-481e-8f8e-b28ce910cb97"),
                    Url = "https://www.cdc.gov/coronavirus/2019-ncov/community/schools-childcare/index.html?CDC_AA_refVal=https%3A%2F%2Fwww.cdc.gov%2Fcoronavirus%2F2019-ncov%2Fcommunity%2Fschools-childcare%2Fchild-care-decision-tool.html",
                    Name = "Childcare Decision Tools",
                    Description = "Schools and childcare info from the CDC in regards to COVID-19.",
                    Origin = "CDC",
                    Published = DateTime.Parse("10/16/2020"),
                    Type = LinkType.Website,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null
                },
                new Link {//
                    Id = Guid.Parse("1921a6cb-7ef9-47ba-ba7c-0bc7f47d028c"),
                    Url = "https://hawaiicovid19.com/",
                    Name = "Hawaii Department of Health Covid 19",
                    Description = "The homepage for Hawaii's portal in response to Covid-19.",
                    Origin = "State of Hawaii",
                    Published = DateTime.Parse("11/10/2020"),
                    Type = LinkType.Website,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null
                },
                new Link {//
                    Id = Guid.Parse("b59efa1b-9b14-4313-bf8a-18088bc3ad8c"),
                    Url = "https://sites.google.com/eoel.hawaii.gov/covid-19/home/families-resources/subsidy-and-scholarship-information?authuser=0",
                    Name = "Subsidy And Scholarship Information",
                    Description = "Information for Child Care Assistance and Early Education Scholarships",
                    Origin = "State of Hawaii Executive Office on Early Learning",
                    Published = null,
                    Type = LinkType.Website,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null
                },
                new Link {//
                    Id = Guid.Parse("8feb1de4-7011-4939-8ea1-25927280d0dd"),
                    Url = "https://www.cdc.gov/coronavirus/2019-ncov/community/schools-childcare/parent-checklist.html?CDC_AA_refVal=https%3A%2F%2Fwww.cdc.gov%2Fcoronavirus%2F2019-ncov%2Fcommunity%2Fschools-childcare%2Fchecklist.html",
                    Name = "Back to School Planning: Checklists to Guide Parents, Guardians, and Caregivers",
                    Description = "Checklist for teachers and parents in regards to going back to school during the pandemic.",
                    Origin = "CDC",
                    Published = DateTime.Parse("08/20/2020"),
                    Type = LinkType.Website,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null
                },
                new Link {//
                    Id = Guid.Parse("578a9540-9f86-48f7-8dea-ab1db8033422"),
                    Url = "https://sites.google.com/eoel.hawaii.gov/covid-19/home/families-resources/family-resources-for-reopening-phase?authuser=0",
                    Name = "Family Resources for Reopening Phase",
                    Description = "Resources for parents or caregivers that need information about transitioning in the re-opening phase for the state",
                    Origin = "State of Hawaii Executive Office on Early Learning",
                    Published = null,
                    Type = LinkType.Website,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null
                },
                new Link {//
                    Id = Guid.Parse("43dfcbd5-f4ac-44bc-a801-660061e53125"),
                    Url = "https://www.surveymonkey.com/r/QCHK2016",
                    Name = "Eligibility Screening for Child Care Assistance",
                    Description = "A survey to determine if the parents are eligible to receive child care assistance",
                    Origin = "Quality Care for Hawaiian Keiki",
                    Published = DateTime.Parse("10/01/2019"),
                    Type = LinkType.Website,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null
                },
                new Link {//
                    Id = Guid.Parse("62bcbadc-1b42-437f-9a13-3f52d76123aa"),
                    Url = "https://www.ksbe.edu/apply/financial_aid/preschool/pauahi_keiki_scholars/",        
                    Name = "Puahi Keiki Scholars",
                    Description = "Information on applying for the Pauahi Keiki Scholars (PKS) scholarship.",
                    Origin = "Kamehameha Schools",
                    Published = null,      
                    Type = LinkType.Website,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null
                },
                new Link {//
                    Id = Guid.Parse("a2bdc0c4-fea7-4e66-90dc-a5d068c854b9"),
                    Url = "https://mfss.org/",        
                    Name = "Maui Family Support Services",
                    Description = "The homepage for Maui Family Support Services, Inc.",
                    Origin = "MFSS",
                    Published = null,       
                    Type = LinkType.Website,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null
                },
                new Link {//
                    Id = Guid.Parse("a4efa4f5-19f6-43da-8710-34e12656dd36"),
                    Url = "https://www.zerotothree.org/resources/223-creating-routines-for-love-and-learning",        
                    Name = "Creating Routines for Love and Learning",
                    Description = "Routines for the very young child with love and learning.",
                    Origin = "zerotothree",
                    Published = DateTime.Parse("02/20/2010"),     
                    Type = LinkType.Website,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null
                },
                new Link {//
                    Id = Guid.Parse("10ef6655-5cfb-40d3-b4ea-138fdd9ffd77"),
                    Url = "https://www.pbs.org/parents/thrive/schools-closed-how-to-make-a-new-home-routine",        
                    Name = "How to Make a New Home Routine",
                    Description = "How to plan and make home routines.",
                    Origin = "PBS",
                    Published = DateTime.Parse("03/17/2020"),     
                    Type = LinkType.Website,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null
                },
                new Link {//
                    Id = Guid.Parse("35af062d-cdee-4bf2-8d10-3b2a4d5d35a4"),
                    Url = "https://raisingchildren.net.au/grown-ups/family-life/routines-rituals-relationships/family-routines",        
                    Name = "Family routines: how and why they work",
                    Description = "Advice on how to make a family routine and why they work.",
                    Origin = "Raising Children",
                    Published = DateTime.Parse("11/15/2017"),     
                    Type = LinkType.Website,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null
                },
                new Link {//
                    Id = Guid.Parse("39e90802-df2e-4f05-8bf0-ec3cda2782a5"),
                    Url = "https://www.cnn.com/2020/05/16/health/preschool-childcare-reopen-parenting-coronavirus-wellness/index.html",        
                    Name = "Sending Your Child Back to School with COVID-19",
                    Description = "An article on the possible outcomes of sending your child back to school.",
                    Origin = "CNN",
                    Published = DateTime.Parse("05/16/2020"),     
                    Type = LinkType.Website,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null
                },
                new Link {//
                    Id = Guid.Parse("5ef9d6b1-47bd-4887-bfd2-e130f3f29cdc"),
                    Url = "https://docs.google.com/document/d/1SvIdgTx9djKO6SjyvPDsoGlkgE3iExmi3qh2KRRku_w/preview?fbclid=IwAR22dnud3aOY2r9HW2yPyL_QXopce2D1hFf5ozlolgdW279Yo6q7l8Zm1tw ",        
                    Name = "Virtual Field Trips",
                    Description = "Over 30 Virtual Field Trips with Links",
                    Origin = "[Unknown]",
                    Published = null,     
                    Type = LinkType.Document,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null
                },
                new Link {//
                    Id = Guid.Parse("1a627430-6cef-4a81-88f2-79ee9adfcb12"),
                    Url = "https://www.hawaii-can.org/rights_paid_leave_covid19",        
                    Name = "Know your rights: Paid sick days & paid leave during COVID-19",
                    Description = "A description of parents rights to paid sick-leave and time-off during COVID-19",
                    Origin = "Hawaii Children's Action Network",
                    Published = null,     
                    Type = LinkType.Website,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null
                },
                new Link {//
                    Id = Guid.Parse("fc13c569-da0c-4f19-bba0-f1491850d3d4"),
                    Url = "https://wakelet.com/wake/c815de12-b0be-4701-a25b-afe850025f2e",        
                    Name = "Wakelet: Learn At Home",
                    Description = "A page with links to help with learning at home.",
                    Origin = "Wakelet",
                    Published = null,       
                    Type = LinkType.Website,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null
                },
                new Link {//
                    Id = Guid.Parse("ea94b18d-7c05-4e13-93ab-ab448452991e"),
                    Url = "https://dreme.stanford.edu/news/spatial-reasoning-why-math-talk-about-more-numbers ",        
                    Name = "Spatial Reasoning: Why Math Talk is About More Than Numbers",
                    Description = "An article about spatial reasoning by the Development and Research in Early Math Education.",
                    Origin = "DREME",
                    Published = DateTime.Parse("12/11/2017"),       
                    Type = LinkType.Website,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null
                },
                new Link {//
                    Id = Guid.Parse("8356106d-f708-48fb-9499-cf0dd3b677c5"),
                    Url = "https://www.cdc.gov/coronavirus/2019-ncov/community/schools-childcare/summer-camps.html",        
                    Name = "Suggestions for Youth and Summer Camps",
                    Description = "Ways to make camps safe for kids and staff",
                    Origin = "CDC",
                    Published = DateTime.Parse("10/29/2020"),       
                    Type = LinkType.Website,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null
                },
                new Link {//
                    Id = Guid.Parse("3334b097-20a9-453f-9ef7-919432abeb64"),
                    Url = "https://dreme.stanford.edu/news/making-most-talk-about-numbers",        
                    Name = "Making the Most of Talk About Numbers",
                    Description = "The importance of numbers and how to support number learning by the Development and Research in Early Math Education.",
                    Origin = "DREME",
                    Published = DateTime.Parse("10/31/2017"),       
                    Type = LinkType.Website,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null
                },
                new Link {//
                    Id = Guid.Parse("a8369011-960d-41e1-ab81-111106be561e"),
                    Url = "http://learningtogrowhawaii.org/activity/",        
                    Name = "Learning to Grow Activities",
                    Description = "Activities by the University of Hawaii at Manoa's Learnign to Grow page.",
                    Origin = "University of Hawaii Manoa",
                    Published = null,       
                    Type = LinkType.Website,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null
                },
                new Link {//
                    Id = Guid.Parse("4eb39313-02a6-4139-93e5-b39609fc4167"),
                    Url = "https://dreme.stanford.edu/news/executive-functions-supporting-foundational-skills-early-math-learning",        
                    Name = "Executive Functions: Supporting Foundational Skills for Early Math Learning",
                    Description = "Supporting foundational math skills from the Development and Research in Early Math Education.",
                    Origin = "DREME",
                    Published = DateTime.Parse("03/27/2018"),       
                    Type = LinkType.Website,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null
                },
                new Link {//
                    Id = Guid.Parse("9a848840-6c03-4df8-bfb4-1122c8400c06"),
                    Url = "https://sites.google.com/eoel.hawaii.gov/covid-19/home/families-resources/find-care?authuser=0",        
                    Name = "Finding Care for Your Child",
                    Description = "Resources to get children connected to the care they need as the parents return to work.",
                    Origin = "State of Hawaii Executive Office of Early Learning",
                    Published = null,       
                    Type = LinkType.Website,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null
                },
                new Link {//
                    Id = Guid.Parse("4190e202-1477-40a2-935a-d85ba55d713a"),
                    Url = "https://sites.google.com/eoel.hawaii.gov/covid-19/home/families-resources/at-home-resources-for-families?authuser=0",        
                    Name = "At-Home Resources for Families from Executive Office on Early Learning",
                    Description = "A page with many links for at-home resources for families by the Executive Office on Early Learning.",
                    Origin = "EOEL",
                    Published = null,       
                    Type = LinkType.Website,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null
                },
                new Link {//
                    Id = Guid.Parse("96c7a4ef-43d0-4d89-a3c9-5a3974f36533"),
                    Url = "https://www.cdc.gov/ncbddd/actearly/milestones/index.html",        
                    Name = "CDC's Development Milestones for Infants",
                    Description = "A page that tells you about how far your child should be in there development milestones",
                    Origin = "CDC",
                    Published = DateTime.Parse("03/27/2018"),       
                    Type = LinkType.Website,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null
                },
                new Link {//
                    Id = Guid.Parse("0ce04084-dcb1-4250-8d7c-a73385cbb76d"),
                    Url = "https://www.naeyc.org/resources/pubs/tyc/feb2017/creating-coding-stories-and-games",        
                    Name = "Coding with Children",
                    Description = "An article on what coding is and how can you get children started with coding.",
                    Origin = "NAEYC",
                    Published = DateTime.Parse("03/01/2017"),       
                    Type = LinkType.Website,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null
                },
                new Link {//
                    Id = Guid.Parse("fe7a07aa-7456-481a-971d-fcc0a65fb34e"),
                    Url = "https://pittsburghkids.org/museumathome?fbclid=IwAR3yseklPsMAcnjBxaoU31-25ZBa1iefBJq49SY5JahFrenX00N6JPfgvAY",        
                    Name = "Children's Museum Pittsburgh: Museum at Home Activities",
                    Description = "The museums at home page for Children's Museum",
                    Origin = "Children's Museum",
                    Published = null,       
                    Type = LinkType.Website,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null
                },
                new Link {//
                    Id = Guid.Parse("1ccf53a1-ceb8-43cd-beb1-27efbdc8f25e"),
                    Url = "http://sohawaii.org/stay-fit-with-sohi/",        
                    Name = "Stay Fit with SOHI",
                    Description = "Special Olympics Hawaii Fit Programs At Home.",
                    Origin = "Special Olympics Hawaii",
                    Published = null,       
                    Type = LinkType.Website,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null
                },
                new Link {//
                    Id = Guid.Parse("0eba1889-edc2-48c1-a5eb-45fc773e192c"),
                    Url = "https://sites.google.com/view/uclamp-math-at-home/home?authuser=0",        
                    Name = "UCLAMP: Math at Home",
                    Description = "UCLAMP homepage that includes how to stay engaged with math at home.",
                    Origin = "Special Olympics Hawaii",
                    Published = null,       
                    Type = LinkType.Website,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null
                } 
            );
        }
    }
}