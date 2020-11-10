using System;

using Microsoft.EntityFrameworkCore;

using OhanaSupport.Models;
using OhanaSupport.Enumerators;

namespace OhanaSupport.Seeders {
    public class LinkSeeder {
        public void Seed(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Link>().HasData(
                new Link {
                    Id = Guid.NewGuid(),
                    Url = "https://www.zerotothree.org/resources/3211-why-are-people-wearing-masks-why-are-people-covering-their-faces",
                    Name = "Why are people wearing masks? Why are people covering their faces?",
                    Description = "Talking to children about the use of masks and talking to children about covid 19 ",
                    Origin = "zerotothree",
                    Published = null,
                    Type = LinkType.Website,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null
                },
                new Link {
                    Id = Guid.NewGuid(),
                    Url = "https://humanservices.hawaii.gov/wp-content/uploads/2020/05/Guidelines-for-Child-Care-Facilities-2020-05-19-final.pdf",
                    Name = "Guidelines for Child Care Facilities to Reopen or Continue to Care",
                    Description = "A checklist or guideline to follow for childcare facilities to reopen or continue care.",
                    Origin = "Human Services",
                    Published = DateTime.Parse("05/19/2020"),
                    Type = LinkType.Document,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null
                },
                new Link {
                    Id = Guid.NewGuid(),
                    Url = "https://www.fatherly.com/health-science/daycare-coronavirus-safety-health/",
                    Name = "Is it time to send your kid back to daycare",
                    Description = "An article avocating the pros and cons of sending your child back to daycare.",
                    Origin = "Fatherly",
                    Published = DateTime.Parse("05/14/2020"),
                    Type = LinkType.Website,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null
                },
                new Link {
                    Id = Guid.NewGuid(),
                    Url = "https://sites.google.com/eoel.hawaii.gov/covid-19/home?authuser=0", 
                    Name = "COVID",
                    Description = "Covid 19 recources for families with young kids that need help with child care, daycare, and as well as donations. For Child providers it is a place to bring recources together for providers ",
                    Origin = "Executive Office on Early Learning, State of Hawaii",
                    Published = null,
                    Type = LinkType.Website,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null
                },
                new Link {
                    Id = Guid.NewGuid(),
                    Url = " https://www.cdc.gov/coronavirus/2019-nCoV/index.html",
                    Name = "Learn more about the novel coronavirus from the CDC",
                    Description = "The CDC main website explaining the Corona Virus",
                    Origin = "CDC",
                    Published = null,
                    Type = LinkType.Website,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null
                },
                new Link {
                    Id = Guid.NewGuid(),
                    Url = "https://info.teachstone.com/blog/keep-children-engaged-while-at-home-with-a-daily-schedule?utm_campaign=COVID-19&utm_source=hs_email&utm_medium=email&utm_content=85052481&_hsenc=p2ANqtz-_UYrZW7EKyGon7LxbuMktCDHvUCQI0BKU_wHSLtS-s2lB-Y33_R1oXSAma5dH3GT09NfdpeBBLsL-AoZ56eBkOBQ7zqg&_hsmi=85052481",
                    Name = "Use This Daily Schedule to Keep Children at Home Engaged",
                    Description = "Advice for how to plan daily schedules for children and keep them engaged at home.",
                    Origin = "Teachstone",
                    Published = DateTime.Parse("03/18/2020"),
                    Type = LinkType.Website,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null
                },
                new Link {
                    Id = Guid.NewGuid(),
                    Url = " https://www.zerotothree.org/resources/3264-at-home-activity-guide",
                    Name = "At Home Activities for Infants and Toddlers",
                    Description = "Playing safely with children at home",
                    Origin = "zerotothree",
                    Published = DateTime.Parse("03/16/2020"),
                    Type = LinkType.Website,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null
                },
                new Link {
                    Id = Guid.NewGuid(),
                    Url = "https://www.cdc.gov/handwashing/handwashing-family.html", 
                    Name = "CDC Centers of Desease Control",
                    Description = "Helping Children Develop handwashing skills",
                    Origin = "CDC",
                    Published = DateTime.Parse("09/10/2020"),
                    Type = LinkType.Website,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null
                },
                new Link {
                    Id = Guid.NewGuid(),
                    Url = "https://docs.google.com/document/d/1u1QkZ0ZMUTFc6tfyzyJTZYoUixCC8H9p5rcQsKCmdHk/edit",
                    Name = "A Thriving Lahui",
                    Description = "Advice for how to plan daily schedules for children and keep them engaged at home.",
                    Origin = "Teachstone",
                    Published = DateTime.Parse("08/21/2020"),
                    Type = LinkType.Document,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null
                },     
                new Link {
                    Id = Guid.NewGuid(),
                    Url = "https://www.zerotothree.org/resources/3413-what-comes-next-back-to-child-care-following-shelter-in-place",
                    Name = "What Comes Next: Back to Child Care Following Shelter-in-Place",
                    Description = "Advice on what to do and know before sending your child back to childcare.",
                    Origin = "zerotothree",
                    Published = DateTime.Parse("04/28/2020"),
                    Type = LinkType.Website,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null
                },
                new Link {
                    Id = Guid.NewGuid(),
                    Url = "https://governor.hawaii.gov/emergency-proclamations/",
                    Name = "State of Hawaii Emergency Proclamations",
                    Description = "Emergency proclamations for the state of Hawaii on governor.hawaii.gov",
                    Origin = "State of Hawaii",
                    Published = null,
                    Type = LinkType.Website,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null
                },  
                new Link {
                    Id = Guid.NewGuid(),
                    Url = "https://www.hawaiicounty.gov/departments/civil-defense/active-emergency-proclamations",
                    Name = "County of Hawaii Emergency Proclamations",
                    Description = "Emergency proclamations for the county of Hawaii on hawaiicounty.gov",
                    Origin = "Hawaii County",
                    Published = null,
                    Type = LinkType.Website,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null
                },
                new Link {
                    Id = Guid.NewGuid(),
                    Url = "https://www.honolulu.gov/mayor/proclamations-orders-and-rules.html",
                    Name = "City and County of Honolulu Covid 19 Response",
                    Description = "The proclamations, orders, and rules in response to Covid 19 for the City and County of Honolulu.",
                    Origin = "City and County of Honolulu",
                    Published = null,
                    Type = LinkType.Website,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null
                },
                new Link {
                    Id = Guid.NewGuid(),
                    Url = "https://www.kauai.gov/Government/Departments-Agencies/Emergency-Management-Agency-formerly-Civil-Defense/Emergency-Proclamations",
                    Name = "County of Kaua`i Emergency Proclamations",
                    Description = "Emergency Proclamations for the County of Kaua`i.",
                    Origin = "County of Kaua`i",
                    Published = null,
                    Type = LinkType.Website,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null
                },
                new Link {
                    Id = Guid.NewGuid(),
                    Url = "https://www.mauicounty.gov/2006/Declarations",
                    Name = "County of Maui Emergency Declarations",
                    Description = "Emergency Declarations for the County of Maui.",
                    Origin = "County of Maui",
                    Published = null,
                    Type = LinkType.Website,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null
                },
                new Link {
                    Id = Guid.NewGuid(),
                    Url = "https://www.cdc.gov/coronavirus/2019-ncov/downloads/php/CDC-Activities-Initiatives-for-COVID-19-Response.pdf",
                    Name = "CDC Activities and Initiatives Supporting the COVID-19 Response and the President's Plan for Opening America Up Again",
                    Description = "The surveillance and control goals and activities from the CDC to support response to COVID-19.",
                    Origin = "CDC",
                    Published = DateTime.Parse("05/01/2020"),
                    Type = LinkType.Website,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null
                },
                new Link {
                    Id = Guid.NewGuid(),
                    Url = "https://www.cdc.gov/coronavirus/2019-ncov/community/schools-childcare/index.html?CDC_AA_refVal=https%3A%2F%2Fwww.cdc.gov%2Fcoronavirus%2F2019-ncov%2Fcommunity%2Fschools-childcare%2Fchild-care-decision-tool.html",
                    Name = "Childcare Decision Tools",
                    Description = "Schools and childcare info from the CDC in regards to COVID-19.",
                    Origin = "CDC",
                    Published = DateTime.Parse("10/16/2020"),
                    Type = LinkType.Website,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null
                }
            );
        }
    }
}