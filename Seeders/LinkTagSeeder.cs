using System;

using Microsoft.EntityFrameworkCore;

using OhanaSupport.Models;

namespace OhanaSupport.Seeders {
    public class LinkTagSeeder {
        public void Seed(ModelBuilder modelBuilder){
            modelBuilder.Entity<LinkTag>().HasData(
                new LinkTag {
                    LinkId = Guid.Parse("6058a82e-c1dc-414c-90c3-200a97944b8d"), //Why are ppl wearing masks
                    TagId = Guid.Parse("cbbc812e-3cab-42b9-aeca-f91cf21194c1")   //COVID
                },
                new LinkTag {
                    LinkId = Guid.Parse("6058a82e-c1dc-414c-90c3-200a97944b8d"), 
                    TagId = Guid.Parse("2a8f120d-fb1c-4cf8-8f2b-65179bfe59fc")   //Article
                },
                new LinkTag {
                    LinkId = Guid.Parse("6058a82e-c1dc-414c-90c3-200a97944b8d"), 
                    TagId = Guid.Parse("545a3223-1a97-43a2-ae74-60ff4dd2b7ec")   //Family
                },
                new LinkTag {
                    LinkId = Guid.Parse("6058a82e-c1dc-414c-90c3-200a97944b8d"), 
                    TagId = Guid.Parse("e9c19fff-b42b-49d1-8309-02ae412a60de")   //Keiki
                },
                new LinkTag {
                    LinkId = Guid.Parse("6058a82e-c1dc-414c-90c3-200a97944b8d"), 
                    TagId = Guid.Parse("d416b04b-83b2-4f36-83bf-5b7fa817ee2c")   //Childcare
                },
                new LinkTag {
                    LinkId = Guid.Parse("6058a82e-c1dc-414c-90c3-200a97944b8d"), 
                    TagId = Guid.Parse("23e31995-07e9-4ef1-a79c-297d29e5c8dd")   //Masks
                },
                new LinkTag {
                    LinkId = Guid.Parse("6058a82e-c1dc-414c-90c3-200a97944b8d"), 
                    TagId = Guid.Parse("aacd600b-0eeb-4a52-b147-0f209549885f")   //Children
                },
                new LinkTag {
                    LinkId = Guid.Parse("500dc1df-9607-4e2a-8a23-e138692382c5"), //Guidelines for Child Care Facilities to Reopen or Continue Care
                    TagId = Guid.Parse("cbbc812e-3cab-42b9-aeca-f91cf21194c1") //covid
                },
                new LinkTag {
                    LinkId = Guid.Parse("500dc1df-9607-4e2a-8a23-e138692382c5"),
                    TagId = Guid.Parse("545a3223-1a97-43a2-ae74-60ff4dd2b7ec") //family
                },
                new LinkTag {
                    LinkId = Guid.Parse("500dc1df-9607-4e2a-8a23-e138692382c5"),
                    TagId = Guid.Parse("d416b04b-83b2-4f36-83bf-5b7fa817ee2c") //childcare
                },
                new LinkTag {
                    LinkId = Guid.Parse("500dc1df-9607-4e2a-8a23-e138692382c5"),
                    TagId = Guid.Parse("e9c19fff-b42b-49d1-8309-02ae412a60de") //keiki
                },
                new LinkTag {
                    LinkId = Guid.Parse("500dc1df-9607-4e2a-8a23-e138692382c5"),
                    TagId = Guid.Parse("6dc7eabd-f824-457f-a738-9bac58b5604b") //teacher
                },
                new LinkTag {
                    LinkId = Guid.Parse("500dc1df-9607-4e2a-8a23-e138692382c5"),
                    TagId = Guid.Parse("958fa84a-469b-42c3-a6f2-9ee4276b2e40") //education
                },
                new LinkTag {
                    LinkId = Guid.Parse("89db9df9-b7aa-44da-a446-a240e64d4b5c"), //Is it time to send your kid back to daycare
                    TagId = Guid.Parse("cbbc812e-3cab-42b9-aeca-f91cf21194c1") //covid
                },
                new LinkTag {
                    LinkId = Guid.Parse("89db9df9-b7aa-44da-a446-a240e64d4b5c"),
                    TagId = Guid.Parse("545a3223-1a97-43a2-ae74-60ff4dd2b7ec") //family
                },
                new LinkTag {
                    LinkId = Guid.Parse("89db9df9-b7aa-44da-a446-a240e64d4b5c"),
                    TagId = Guid.Parse("ecf04aee-4f83-4631-998d-f398684a1824") //support
                },
                new LinkTag {
                    LinkId = Guid.Parse("89db9df9-b7aa-44da-a446-a240e64d4b5c"),
                    TagId = Guid.Parse("e9c19fff-b42b-49d1-8309-02ae412a60de") //keiki
                },
                new LinkTag {
                    LinkId = Guid.Parse("89db9df9-b7aa-44da-a446-a240e64d4b5c"),
                    TagId = Guid.Parse("d416b04b-83b2-4f36-83bf-5b7fa817ee2c") //childcare
                },
                new LinkTag {
                    LinkId = Guid.Parse("89db9df9-b7aa-44da-a446-a240e64d4b5c"),
                    TagId = Guid.Parse("2a8f120d-fb1c-4cf8-8f2b-65179bfe59fc") //article
                },
                new LinkTag {
                    LinkId = Guid.Parse("c2b77138-6689-49cc-9d79-39389c20cee2"), //COVID
                    TagId = Guid.Parse("37b9e987-6a33-4514-a6d2-835903743369") //homepage
                },
                new LinkTag {
                    LinkId = Guid.Parse("c2b77138-6689-49cc-9d79-39389c20cee2"),
                    TagId = Guid.Parse("cbbc812e-3cab-42b9-aeca-f91cf21194c1") //covid
                },
                new LinkTag {
                    LinkId = Guid.Parse("c2b77138-6689-49cc-9d79-39389c20cee2"),
                    TagId = Guid.Parse("a8fd4501-4100-497b-8a17-8ddba4fd7886") //eoel
                },
                new LinkTag {
                    LinkId = Guid.Parse("4267f54f-70c8-4fa6-9f79-e6c7ffd35ef7"), // Learn more about the novel coronavirus from the CDC
                    TagId = Guid.Parse("344c0405-f0b9-408e-ae56-063bfa06d705") //federal
                },
                new LinkTag {
                    LinkId = Guid.Parse("4267f54f-70c8-4fa6-9f79-e6c7ffd35ef7"),
                    TagId = Guid.Parse("381184be-55af-4f55-9fd5-94a5c5864582") //gov
                },
                new LinkTag {
                    LinkId = Guid.Parse("4267f54f-70c8-4fa6-9f79-e6c7ffd35ef7"),
                    TagId = Guid.Parse("40f84a57-8260-47c3-8e53-55f5c67719c6") //corona
                },
                new LinkTag {
                    LinkId = Guid.Parse("4267f54f-70c8-4fa6-9f79-e6c7ffd35ef7"), 
                    TagId = Guid.Parse("cbbc812e-3cab-42b9-aeca-f91cf21194c1") //covid
                },
                new LinkTag {
                    LinkId = Guid.Parse("4267f54f-70c8-4fa6-9f79-e6c7ffd35ef7"),
                    TagId = Guid.Parse("a48f9a90-f6a0-4f83-9750-b1ab9540a901") //coronavirus
                },
                new LinkTag {
                    LinkId = Guid.Parse("4267f54f-70c8-4fa6-9f79-e6c7ffd35ef7"),
                    TagId = Guid.Parse("cc857f6e-0f23-481a-8a21-19164e6414f1") //covid-19
                },
                new LinkTag {
                    LinkId = Guid.Parse("d23dba1f-e4ff-4392-aa3b-3a0d2a163cf5"), // Use This Daily Schedule to Keep Children at Home Engaged
                    TagId = Guid.Parse("a7f9abec-e209-4a5c-99e3-bdb3a679a2f7") //routine
                },
                new LinkTag {
                    LinkId = Guid.Parse("d23dba1f-e4ff-4392-aa3b-3a0d2a163cf5"),
                    TagId = Guid.Parse("9e7303bc-730a-4d5c-a110-57029ffd7ff4") //schedule
                },
                new LinkTag {
                    LinkId = Guid.Parse("d23dba1f-e4ff-4392-aa3b-3a0d2a163cf5"),
                    TagId = Guid.Parse("545a3223-1a97-43a2-ae74-60ff4dd2b7ec") //family
                },
                new LinkTag {
                    LinkId = Guid.Parse("d23dba1f-e4ff-4392-aa3b-3a0d2a163cf5"),
                    TagId = Guid.Parse("aacd600b-0eeb-4a52-b147-0f209549885f") //children
                },
                new LinkTag {
                    LinkId = Guid.Parse("d23dba1f-e4ff-4392-aa3b-3a0d2a163cf5"),
                    TagId = Guid.Parse("e9c19fff-b42b-49d1-8309-02ae412a60de") //keiki
                },
                new LinkTag {
                    LinkId = Guid.Parse("d23dba1f-e4ff-4392-aa3b-3a0d2a163cf5"),
                    TagId = Guid.Parse("8debb346-fef6-44d3-baa8-37a0a12291a0") //parenting
                },
                new LinkTag {
                    LinkId = Guid.Parse("9b15c06c-b07b-47c6-a95c-af95825180b3"), //at home ativities for infants and toddlers
                    TagId = Guid.Parse("cbbc812e-3cab-42b9-aeca-f91cf21194c1") //covid
                },
                new LinkTag {
                    LinkId = Guid.Parse("9b15c06c-b07b-47c6-a95c-af95825180b3"),
                    TagId = Guid.Parse("9a608f65-9834-47d9-85ce-2818907b0a3b") //home
                },
                new LinkTag {
                    LinkId = Guid.Parse("9b15c06c-b07b-47c6-a95c-af95825180b3"),
                    TagId = Guid.Parse("87c3dfd2-eb9c-474c-bc20-d2586eff3fe2") //activities
                },
                new LinkTag {
                    LinkId = Guid.Parse("9b15c06c-b07b-47c6-a95c-af95825180b3"), 
                    TagId = Guid.Parse("aacd600b-0eeb-4a52-b147-0f209549885f") //children
                },
                new LinkTag {
                    LinkId = Guid.Parse("9b15c06c-b07b-47c6-a95c-af95825180b3"),
                    TagId = Guid.Parse("e9c19fff-b42b-49d1-8309-02ae412a60de") //keiki
                },
                new LinkTag {
                    LinkId = Guid.Parse("9b15c06c-b07b-47c6-a95c-af95825180b3"),
                    TagId = Guid.Parse("8debb346-fef6-44d3-baa8-37a0a12291a0") //parenting
                },
                new LinkTag {
                    LinkId = Guid.Parse("9b15c06c-b07b-47c6-a95c-af95825180b3"),
                    TagId = Guid.Parse("a7f9abec-e209-4a5c-99e3-bdb3a679a2f7") //routine
                },
                new LinkTag {
                    LinkId = Guid.Parse("9b15c06c-b07b-47c6-a95c-af95825180b3"),
                    TagId = Guid.Parse("8da99e93-ba60-40de-89f0-9032e0a5631b") //parent
                },
                new LinkTag {
                    LinkId = Guid.Parse("b82d52f2-4512-4ff0-a8e5-2ddcfe3bd2d6"),//Helping Children Develop handwashing skills
                    TagId = Guid.Parse("344c0405-f0b9-408e-ae56-063bfa06d705") // Federal
                },
                new LinkTag {
                    LinkId = Guid.Parse("b82d52f2-4512-4ff0-a8e5-2ddcfe3bd2d6"),
                    TagId = Guid.Parse("cbbc812e-3cab-42b9-aeca-f91cf21194c1") // Covid
                },
                new LinkTag {
                    LinkId = Guid.Parse("b82d52f2-4512-4ff0-a8e5-2ddcfe3bd2d6"),
                    TagId = Guid.Parse("a48f9a90-f6a0-4f83-9750-b1ab9540a901") //coronavirus
                },
                new LinkTag {
                    LinkId = Guid.Parse("b82d52f2-4512-4ff0-a8e5-2ddcfe3bd2d6"),
                    TagId = Guid.Parse("e9c19fff-b42b-49d1-8309-02ae412a60de") //keiki
                },
                new LinkTag {
                    LinkId = Guid.Parse("b82d52f2-4512-4ff0-a8e5-2ddcfe3bd2d6"),
                    TagId = Guid.Parse("aacd600b-0eeb-4a52-b147-0f209549885f") //children
                },
                new LinkTag {
                    LinkId = Guid.Parse("b82d52f2-4512-4ff0-a8e5-2ddcfe3bd2d6"),
                    TagId = Guid.Parse("b22ec78a-cfb1-4278-905d-857b79f7fa0b") //handwashing
                },
                new LinkTag {
                    LinkId = Guid.Parse("62673a98-212a-4086-81b8-c81c6d3d4dc1"),//thriving lahui
                    TagId = Guid.Parse("a6ce6fc1-ebf4-4286-80da-fccf5aa60266") //lahui
                },
                new LinkTag {
                    LinkId = Guid.Parse("62673a98-212a-4086-81b8-c81c6d3d4dc1"),
                    TagId = Guid.Parse("890985c5-b423-4fd4-bf40-91aa9bd2e5dc") //hawaiian
                },
                new LinkTag {
                    LinkId = Guid.Parse("62673a98-212a-4086-81b8-c81c6d3d4dc1"),
                    TagId = Guid.Parse("cf0def79-5b99-4754-a775-b76f14f3bbe4") //culture
                },
                new LinkTag {
                    LinkId = Guid.Parse("62673a98-212a-4086-81b8-c81c6d3d4dc1"),
                    TagId = Guid.Parse("9cb56da2-a1a1-4f5a-bf76-5392d0a9b049") //resource
                },
                new LinkTag {
                    LinkId = Guid.Parse("62673a98-212a-4086-81b8-c81c6d3d4dc1"),
                    TagId = Guid.Parse("958fa84a-469b-42c3-a6f2-9ee4276b2e40") //education
                },
                new LinkTag {
                    LinkId = Guid.Parse("7f411aa8-26af-48f8-8b69-5e7025b4a935"), // What Comes Next: Back to Child Care Following Shelter-in-Place
                    TagId = Guid.Parse("cbbc812e-3cab-42b9-aeca-f91cf21194c1")//covid
                },
                new LinkTag {
                    LinkId = Guid.Parse("7f411aa8-26af-48f8-8b69-5e7025b4a935"),
                    TagId = Guid.Parse("545a3223-1a97-43a2-ae74-60ff4dd2b7ec")//family
                },
                new LinkTag {
                    LinkId = Guid.Parse("7f411aa8-26af-48f8-8b69-5e7025b4a935"),
                    TagId = Guid.Parse("ecf04aee-4f83-4631-998d-f398684a1824")//support
                },
                new LinkTag {
                    LinkId = Guid.Parse("7f411aa8-26af-48f8-8b69-5e7025b4a935"),
                    TagId = Guid.Parse("e9c19fff-b42b-49d1-8309-02ae412a60de")//keiki
                },
                new LinkTag {
                    LinkId = Guid.Parse("7f411aa8-26af-48f8-8b69-5e7025b4a935"),
                    TagId = Guid.Parse("d416b04b-83b2-4f36-83bf-5b7fa817ee2c")//childcare
                },
                new LinkTag {
                    LinkId = Guid.Parse("7f411aa8-26af-48f8-8b69-5e7025b4a935"),
                    TagId = Guid.Parse("2a8f120d-fb1c-4cf8-8f2b-65179bfe59fc")//article
                },
                new LinkTag {
                    LinkId = Guid.Parse("5dc91c8c-a8eb-4d04-8ca0-3de007d17cdc"),//state of hawaii
                    TagId = Guid.Parse("3a06d804-0635-4cd0-81ca-4dbcab0e5c40")//state
                },
                new LinkTag {
                    LinkId = Guid.Parse("5dc91c8c-a8eb-4d04-8ca0-3de007d17cdc"),
                    TagId = Guid.Parse("13c0cc5f-ad64-40bc-90b7-502e92e3d5c0")//hawaii
                },
                new LinkTag {
                    LinkId = Guid.Parse("5dc91c8c-a8eb-4d04-8ca0-3de007d17cdc"),
                    TagId = Guid.Parse("890985c5-b423-4fd4-bf40-91aa9bd2e5dc")//hawaiian
                },
                new LinkTag {
                    LinkId = Guid.Parse("5dc91c8c-a8eb-4d04-8ca0-3de007d17cdc"),
                    TagId = Guid.Parse("e9052ff3-f1fa-4792-ab3f-5a25b3686031")//proclamation
                },
                new LinkTag {
                    LinkId = Guid.Parse("145da347-783c-4fec-b163-ec4c76b306c2"),//county of hawaii
                    TagId = Guid.Parse("13c0cc5f-ad64-40bc-90b7-502e92e3d5c0")//hawaii
                },
                new LinkTag {
                    LinkId = Guid.Parse("145da347-783c-4fec-b163-ec4c76b306c2"),
                    TagId = Guid.Parse("a01dd380-0986-4b18-8e90-523f64fe815b")//county
                },
                new LinkTag {
                    LinkId = Guid.Parse("145da347-783c-4fec-b163-ec4c76b306c2"),
                    TagId = Guid.Parse("b7cc1c6f-ca92-4c00-b899-cdc0aba0590b")//department
                },
                new LinkTag {
                    LinkId = Guid.Parse("85602a47-13d3-4bc0-874e-3dcb5066a4b5"),//honolulu county
                    TagId = Guid.Parse("4acaf4bd-8b6c-4f99-aa82-9baaa28a0740")//honolulu
                },
                new LinkTag {
                    LinkId = Guid.Parse("85602a47-13d3-4bc0-874e-3dcb5066a4b5"),
                    TagId = Guid.Parse("a01dd380-0986-4b18-8e90-523f64fe815b")//county
                },
                new LinkTag {
                    LinkId = Guid.Parse("85602a47-13d3-4bc0-874e-3dcb5066a4b5"),
                    TagId = Guid.Parse("b7cc1c6f-ca92-4c00-b899-cdc0aba0590b")//dept
                },
                new LinkTag {
                    LinkId = Guid.Parse("0b7ad369-255a-418e-85f0-ea9efcdbb04d"),//county of kauai
                    TagId = Guid.Parse("382167e3-7ce7-4422-8c80-e4b2c18934c0")//kauai
                },
                new LinkTag {
                    LinkId = Guid.Parse("0b7ad369-255a-418e-85f0-ea9efcdbb04d"),
                    TagId = Guid.Parse("a01dd380-0986-4b18-8e90-523f64fe815b")//county
                },
                new LinkTag {
                    LinkId = Guid.Parse("0b7ad369-255a-418e-85f0-ea9efcdbb04d"),
                    TagId = Guid.Parse("b7cc1c6f-ca92-4c00-b899-cdc0aba0590b")//dept
                },
                new LinkTag {
                    LinkId = Guid.Parse("1e792fe6-ab89-418e-8456-cfa05a433d25"), //maui of county
                    TagId = Guid.Parse("dc31bb70-1d06-4b28-9ba8-308a56ee9209")//maui
                },
                new LinkTag {
                    LinkId = Guid.Parse("1e792fe6-ab89-418e-8456-cfa05a433d25"),
                    TagId = Guid.Parse("a01dd380-0986-4b18-8e90-523f64fe815b")//county
                },
                new LinkTag {
                    LinkId = Guid.Parse("1e792fe6-ab89-418e-8456-cfa05a433d25"),
                    TagId = Guid.Parse("b7cc1c6f-ca92-4c00-b899-cdc0aba0590b")//dept
                },
                new LinkTag {
                    LinkId = Guid.Parse("595ca34e-fa75-4c0e-b730-62c19cd36fea"), // CDC Activities and Initiatives Supporting the COVID-19 Response and the President's Plan for Opening America Up Again
                    TagId = Guid.Parse("cbbc812e-3cab-42b9-aeca-f91cf21194c1") // Covid
                },
                new LinkTag {
                    LinkId = Guid.Parse("595ca34e-fa75-4c0e-b730-62c19cd36fea"),
                    TagId = Guid.Parse("a69946bc-acb4-4f7d-9eb0-7ed4f0ebac40") //cdc
                },
                new LinkTag {
                    LinkId = Guid.Parse("595ca34e-fa75-4c0e-b730-62c19cd36fea"),
                    TagId = Guid.Parse("87c3dfd2-eb9c-474c-bc20-d2586eff3fe2") //activities
                },
                new LinkTag {
                    LinkId = Guid.Parse("595ca34e-fa75-4c0e-b730-62c19cd36fea"),
                    TagId = Guid.Parse("a48f9a90-f6a0-4f83-9750-b1ab9540a901")//coronavirus
                },
                new LinkTag {
                    LinkId = Guid.Parse("595ca34e-fa75-4c0e-b730-62c19cd36fea"),
                    TagId = Guid.Parse("cc857f6e-0f23-481a-8a21-19164e6414f1")//covid19
                },
                new LinkTag {
                    LinkId = Guid.Parse("305ccacd-ed90-481e-8f8e-b28ce910cb97"),//childcare decision tool
                    TagId = Guid.Parse("d416b04b-83b2-4f36-83bf-5b7fa817ee2c")//childcare
                },
                new LinkTag {
                    LinkId = Guid.Parse("305ccacd-ed90-481e-8f8e-b28ce910cb97"),
                    TagId = Guid.Parse("a69946bc-acb4-4f7d-9eb0-7ed4f0ebac40")//cdc
                },
                new LinkTag {
                    LinkId = Guid.Parse("305ccacd-ed90-481e-8f8e-b28ce910cb97"),
                    TagId = Guid.Parse("958fa84a-469b-42c3-a6f2-9ee4276b2e40")//education
                },
                new LinkTag {
                    LinkId = Guid.Parse("305ccacd-ed90-481e-8f8e-b28ce910cb97"),
                    TagId = Guid.Parse("62025c26-33c8-47b1-919c-acb4191e3280")//school
                },
                new LinkTag {
                    LinkId = Guid.Parse("305ccacd-ed90-481e-8f8e-b28ce910cb97"),
                    TagId = Guid.Parse("cbbc812e-3cab-42b9-aeca-f91cf21194c1")//covid
                },
                new LinkTag {
                    LinkId = Guid.Parse("305ccacd-ed90-481e-8f8e-b28ce910cb97"),
                    TagId = Guid.Parse("a48f9a90-f6a0-4f83-9750-b1ab9540a901") //coronavirus
                },
                new LinkTag {
                    LinkId = Guid.Parse("305ccacd-ed90-481e-8f8e-b28ce910cb97"),
                    TagId = Guid.Parse("cc857f6e-0f23-481a-8a21-19164e6414f1") //covid19
                },
                new LinkTag {
                    LinkId = Guid.Parse("1921a6cb-7ef9-47ba-ba7c-0bc7f47d028c"),//hawaiicovid19.com
                    TagId = Guid.Parse("13c0cc5f-ad64-40bc-90b7-502e92e3d5c0")//hawaii
                },
                new LinkTag {
                    LinkId = Guid.Parse("1921a6cb-7ef9-47ba-ba7c-0bc7f47d028c"),
                    TagId = Guid.Parse("b7cc1c6f-ca92-4c00-b899-cdc0aba0590b")//dept
                },
                new LinkTag {
                    LinkId = Guid.Parse("1921a6cb-7ef9-47ba-ba7c-0bc7f47d028c"),
                    TagId = Guid.Parse("45e34501-421a-4ba3-85d2-b07eb71c3f5c")//health
                },
                new LinkTag {
                    LinkId = Guid.Parse("1921a6cb-7ef9-47ba-ba7c-0bc7f47d028c"),
                    TagId = Guid.Parse("cbbc812e-3cab-42b9-aeca-f91cf21194c1")//covid
                },
                new LinkTag {
                    LinkId = Guid.Parse("1921a6cb-7ef9-47ba-ba7c-0bc7f47d028c"),
                    TagId = Guid.Parse("3a06d804-0635-4cd0-81ca-4dbcab0e5c40")//state
                },
                new LinkTag {
                    LinkId = Guid.Parse("b59efa1b-9b14-4313-bf8a-18088bc3ad8c"),//subsidy and scholarship info
                    TagId = Guid.Parse("cbbc812e-3cab-42b9-aeca-f91cf21194c1")//covid
                },
                new LinkTag {
                    LinkId = Guid.Parse("b59efa1b-9b14-4313-bf8a-18088bc3ad8c"),
                    TagId = Guid.Parse("545a3223-1a97-43a2-ae74-60ff4dd2b7ec")//family
                },
                new LinkTag {
                    LinkId = Guid.Parse("b59efa1b-9b14-4313-bf8a-18088bc3ad8c"),
                    TagId = Guid.Parse("9cb56da2-a1a1-4f5a-bf76-5392d0a9b049")//resource
                },
                new LinkTag {
                    LinkId = Guid.Parse("b59efa1b-9b14-4313-bf8a-18088bc3ad8c"),
                    TagId = Guid.Parse("3d5838f2-4fff-4350-8de1-b6041ef68c9a")//scholarship
                },
                new LinkTag {
                    LinkId = Guid.Parse("b59efa1b-9b14-4313-bf8a-18088bc3ad8c"),
                    TagId = Guid.Parse("2d6c9fcb-a933-4912-a16c-4ad290777cb8")//subsidy
                },
                new LinkTag {
                    LinkId = Guid.Parse("8feb1de4-7011-4939-8ea1-25927280d0dd"),//back to school planning
                    TagId = Guid.Parse("62025c26-33c8-47b1-919c-acb4191e3280")//school
                },
                new LinkTag {
                    LinkId = Guid.Parse("8feb1de4-7011-4939-8ea1-25927280d0dd"),
                    TagId = Guid.Parse("8da99e93-ba60-40de-89f0-9032e0a5631b")//parent
                },
                new LinkTag {
                    LinkId = Guid.Parse("8feb1de4-7011-4939-8ea1-25927280d0dd"),
                    TagId = Guid.Parse("6dc7eabd-f824-457f-a738-9bac58b5604b")//teacher
                },
                new LinkTag {
                    LinkId = Guid.Parse("8feb1de4-7011-4939-8ea1-25927280d0dd"),
                    TagId = Guid.Parse("e9c19fff-b42b-49d1-8309-02ae412a60de")//keiki
                },
                new LinkTag {
                    LinkId = Guid.Parse("8feb1de4-7011-4939-8ea1-25927280d0dd"),
                    TagId = Guid.Parse("aacd600b-0eeb-4a52-b147-0f209549885f")//children
                },
                new LinkTag {
                    LinkId = Guid.Parse("8feb1de4-7011-4939-8ea1-25927280d0dd"),
                    TagId = Guid.Parse("958fa84a-469b-42c3-a6f2-9ee4276b2e40")//education
                },
                new LinkTag {
                    LinkId = Guid.Parse("8feb1de4-7011-4939-8ea1-25927280d0dd"),
                    TagId = Guid.Parse("cbbc812e-3cab-42b9-aeca-f91cf21194c1")//covid
                },
                new LinkTag {
                    LinkId = Guid.Parse("8feb1de4-7011-4939-8ea1-25927280d0dd"),
                    TagId = Guid.Parse("9a608f65-9834-47d9-85ce-2818907b0a3b")//home
                },
                new LinkTag {
                    LinkId = Guid.Parse("578a9540-9f86-48f7-8dea-ab1db8033422"),//family resources for reopening phase
                    TagId = Guid.Parse("cbbc812e-3cab-42b9-aeca-f91cf21194c1")//covid
                },
                new LinkTag {
                    LinkId = Guid.Parse("578a9540-9f86-48f7-8dea-ab1db8033422"),
                    TagId = Guid.Parse("545a3223-1a97-43a2-ae74-60ff4dd2b7ec")//family
                },
                new LinkTag {
                    LinkId = Guid.Parse("578a9540-9f86-48f7-8dea-ab1db8033422"),
                    TagId = Guid.Parse("ecf04aee-4f83-4631-998d-f398684a1824")//support
                },
                new LinkTag {
                    LinkId = Guid.Parse("578a9540-9f86-48f7-8dea-ab1db8033422"),
                    TagId = Guid.Parse("e9c19fff-b42b-49d1-8309-02ae412a60de")//keiki
                },
                new LinkTag {
                    LinkId = Guid.Parse("578a9540-9f86-48f7-8dea-ab1db8033422"),
                    TagId = Guid.Parse("d416b04b-83b2-4f36-83bf-5b7fa817ee2c")//childcare
                },
                new LinkTag {
                    LinkId = Guid.Parse("578a9540-9f86-48f7-8dea-ab1db8033422"),
                    TagId = Guid.Parse("2a8f120d-fb1c-4cf8-8f2b-65179bfe59fc")//article
                },
                new LinkTag {
                    LinkId = Guid.Parse("43dfcbd5-f4ac-44bc-a801-660061e53125"),//surveymonkey
                    TagId = Guid.Parse("2d6c9fcb-a933-4912-a16c-4ad290777cb8")//subsidy
                },
                new LinkTag {
                    LinkId = Guid.Parse("43dfcbd5-f4ac-44bc-a801-660061e53125"),
                    TagId = Guid.Parse("9507c750-c643-47a7-90d3-46633c16c237")//eligibility
                },
                new LinkTag {
                    LinkId = Guid.Parse("43dfcbd5-f4ac-44bc-a801-660061e53125"),
                    TagId = Guid.Parse("7a59d506-1192-47b3-a46d-6ec3a7f88664")//survey
                },
                new LinkTag {
                    LinkId = Guid.Parse("43dfcbd5-f4ac-44bc-a801-660061e53125"),
                    TagId = Guid.Parse("e9c19fff-b42b-49d1-8309-02ae412a60de")//keiki
                },
                new LinkTag {
                    LinkId = Guid.Parse("43dfcbd5-f4ac-44bc-a801-660061e53125"),
                    TagId = Guid.Parse("890985c5-b423-4fd4-bf40-91aa9bd2e5dc")//hawaiian
                },
                new LinkTag {
                    LinkId = Guid.Parse("43dfcbd5-f4ac-44bc-a801-660061e53125"),
                    TagId = Guid.Parse("d416b04b-83b2-4f36-83bf-5b7fa817ee2c")//childcare
                },
                new LinkTag {
                    LinkId = Guid.Parse("62bcbadc-1b42-437f-9a13-3f52d76123aa"),//puahi keiki scholars
                    TagId = Guid.Parse("48d069a2-9c39-4665-9485-22e4b56a7972")//puahi
                },
                new LinkTag {
                    LinkId = Guid.Parse("62bcbadc-1b42-437f-9a13-3f52d76123aa"),
                    TagId = Guid.Parse("e9c19fff-b42b-49d1-8309-02ae412a60de")//keiki
                },
                new LinkTag {
                    LinkId = Guid.Parse("62bcbadc-1b42-437f-9a13-3f52d76123aa"),
                    TagId = Guid.Parse("3d5838f2-4fff-4350-8de1-b6041ef68c9a")//scholarship
                },
                new LinkTag {
                    LinkId = Guid.Parse("62bcbadc-1b42-437f-9a13-3f52d76123aa"),
                    TagId = Guid.Parse("aacd600b-0eeb-4a52-b147-0f209549885f")//children
                },
                new LinkTag {
                    LinkId = Guid.Parse("62bcbadc-1b42-437f-9a13-3f52d76123aa"),
                    TagId = Guid.Parse("96bd77d3-3448-4fb8-88ff-80eed4e40737")//finance
                },
                new LinkTag {
                    LinkId = Guid.Parse("62bcbadc-1b42-437f-9a13-3f52d76123aa"),
                    TagId = Guid.Parse("19ccee14-002c-4bd0-a205-caa0c6acbe36")//aid
                },
                new LinkTag {
                    LinkId = Guid.Parse("62bcbadc-1b42-437f-9a13-3f52d76123aa"),
                    TagId = Guid.Parse("cbbc812e-3cab-42b9-aeca-f91cf21194c1")//covid
                },
                new LinkTag {
                    LinkId = Guid.Parse("a2bdc0c4-fea7-4e66-90dc-a5d068c854b9"),//mfss
                    TagId = Guid.Parse("dc31bb70-1d06-4b28-9ba8-308a56ee9209")//maui
                },
                new LinkTag {
                    LinkId = Guid.Parse("a2bdc0c4-fea7-4e66-90dc-a5d068c854b9"),
                    TagId = Guid.Parse("545a3223-1a97-43a2-ae74-60ff4dd2b7ec")//family
                },
                new LinkTag {
                    LinkId = Guid.Parse("a2bdc0c4-fea7-4e66-90dc-a5d068c854b9"),
                    TagId = Guid.Parse("ecf04aee-4f83-4631-998d-f398684a1824")//support
                },
                new LinkTag {
                    LinkId = Guid.Parse("a2bdc0c4-fea7-4e66-90dc-a5d068c854b9"),
                    TagId = Guid.Parse("dc97a1f5-a068-4ea9-8513-84564acac4c1")//service
                },
                new LinkTag {
                    LinkId = Guid.Parse("a2bdc0c4-fea7-4e66-90dc-a5d068c854b9"),
                    TagId = Guid.Parse("e9c19fff-b42b-49d1-8309-02ae412a60de")//keiki
                },
                new LinkTag {
                    LinkId = Guid.Parse("a4efa4f5-19f6-43da-8710-34e12656dd36"),//routines for the very young child
                    TagId = Guid.Parse("a7f9abec-e209-4a5c-99e3-bdb3a679a2f7")//routine
                },
                new LinkTag {
                    LinkId = Guid.Parse("a4efa4f5-19f6-43da-8710-34e12656dd36"),
                    TagId = Guid.Parse("8da99e93-ba60-40de-89f0-9032e0a5631b")//parent
                },
                new LinkTag {
                    LinkId = Guid.Parse("a4efa4f5-19f6-43da-8710-34e12656dd36"),
                    TagId = Guid.Parse("cd0ada9b-9c35-45ed-b7fc-14079c01ffa7")//babies
                },
                new LinkTag {
                    LinkId = Guid.Parse("a4efa4f5-19f6-43da-8710-34e12656dd36"),
                    TagId = Guid.Parse("cbbc812e-3cab-42b9-aeca-f91cf21194c1")//covd
                },
                new LinkTag {
                    LinkId = Guid.Parse("a4efa4f5-19f6-43da-8710-34e12656dd36"),
                    TagId = Guid.Parse("545a3223-1a97-43a2-ae74-60ff4dd2b7ec")//family
                },
                new LinkTag {
                    LinkId = Guid.Parse("10ef6655-5cfb-40d3-b4ea-138fdd9ffd77"),//how to make a new home routine
                    TagId = Guid.Parse("a7f9abec-e209-4a5c-99e3-bdb3a679a2f7")//routine
                },
                new LinkTag {
                    LinkId = Guid.Parse("10ef6655-5cfb-40d3-b4ea-138fdd9ffd77"),
                    TagId = Guid.Parse("cbbc812e-3cab-42b9-aeca-f91cf21194c1")//covid
                },
                new LinkTag {
                    LinkId = Guid.Parse("10ef6655-5cfb-40d3-b4ea-138fdd9ffd77"),
                    TagId = Guid.Parse("8debb346-fef6-44d3-baa8-37a0a12291a0")//parenting
                },
                new LinkTag {
                    LinkId = Guid.Parse("10ef6655-5cfb-40d3-b4ea-138fdd9ffd77"),
                    TagId = Guid.Parse("545a3223-1a97-43a2-ae74-60ff4dd2b7ec")//family
                },
                new LinkTag {
                    LinkId = Guid.Parse("10ef6655-5cfb-40d3-b4ea-138fdd9ffd77"),
                    TagId = Guid.Parse("9a608f65-9834-47d9-85ce-2818907b0a3b")//home
                },
                new LinkTag {
                    LinkId = Guid.Parse("10ef6655-5cfb-40d3-b4ea-138fdd9ffd77"),
                    TagId = Guid.Parse("62025c26-33c8-47b1-919c-acb4191e3280")//school
                },
                new LinkTag {
                    LinkId = Guid.Parse("35af062d-cdee-4bf2-8d10-3b2a4d5d35a4"),//fam routine
                    TagId = Guid.Parse("a7f9abec-e209-4a5c-99e3-bdb3a679a2f7")//routine
                },
                new LinkTag {
                    LinkId = Guid.Parse("35af062d-cdee-4bf2-8d10-3b2a4d5d35a4"),
                    TagId = Guid.Parse("8debb346-fef6-44d3-baa8-37a0a12291a0")//parenting
                },
                new LinkTag {
                    LinkId = Guid.Parse("35af062d-cdee-4bf2-8d10-3b2a4d5d35a4"),
                    TagId = Guid.Parse("545a3223-1a97-43a2-ae74-60ff4dd2b7ec")//family
                },
                new LinkTag {
                    LinkId = Guid.Parse("35af062d-cdee-4bf2-8d10-3b2a4d5d35a4"),
                    TagId = Guid.Parse("9e7303bc-730a-4d5c-a110-57029ffd7ff4")//schedule
                },
                new LinkTag {
                    LinkId = Guid.Parse("35af062d-cdee-4bf2-8d10-3b2a4d5d35a4"),
                    TagId = Guid.Parse("aacd600b-0eeb-4a52-b147-0f209549885f")//children
                },
                new LinkTag {
                    LinkId = Guid.Parse("39e90802-df2e-4f05-8bf0-ec3cda2782a5"),// Sending Your Child Back to School with COVID-19
                    TagId = Guid.Parse("a7f9abec-e209-4a5c-99e3-bdb3a679a2f7")//routine
                },
                new LinkTag {
                    LinkId = Guid.Parse("39e90802-df2e-4f05-8bf0-ec3cda2782a5"),
                    TagId = Guid.Parse("9e7303bc-730a-4d5c-a110-57029ffd7ff4")//schedule
                },
                new LinkTag {
                    LinkId = Guid.Parse("39e90802-df2e-4f05-8bf0-ec3cda2782a5"),
                    TagId = Guid.Parse("545a3223-1a97-43a2-ae74-60ff4dd2b7ec")//family
                },
                new LinkTag {
                    LinkId = Guid.Parse("39e90802-df2e-4f05-8bf0-ec3cda2782a5"),
                    TagId = Guid.Parse("aacd600b-0eeb-4a52-b147-0f209549885f")//children
                },
                new LinkTag {
                    LinkId = Guid.Parse("39e90802-df2e-4f05-8bf0-ec3cda2782a5"),
                    TagId = Guid.Parse("e9c19fff-b42b-49d1-8309-02ae412a60de")//keiki
                },
                new LinkTag {
                    LinkId = Guid.Parse("39e90802-df2e-4f05-8bf0-ec3cda2782a5"),
                    TagId = Guid.Parse("8debb346-fef6-44d3-baa8-37a0a12291a0")//parenting
                },
                new LinkTag {
                    LinkId = Guid.Parse("5ef9d6b1-47bd-4887-bfd2-e130f3f29cdc"),//virtual field trips
                    TagId = Guid.Parse("8bb5da12-bd2f-4357-bfd3-7628ff23ac81")//virtual
                },
                new LinkTag {
                    LinkId = Guid.Parse("5ef9d6b1-47bd-4887-bfd2-e130f3f29cdc"),
                    TagId = Guid.Parse("e9c19fff-b42b-49d1-8309-02ae412a60de")//keiki
                },
                new LinkTag {
                    LinkId = Guid.Parse("5ef9d6b1-47bd-4887-bfd2-e130f3f29cdc"),
                    TagId = Guid.Parse("aacd600b-0eeb-4a52-b147-0f209549885f")//children
                },
                new LinkTag {
                    LinkId = Guid.Parse("5ef9d6b1-47bd-4887-bfd2-e130f3f29cdc"),
                    TagId = Guid.Parse("958fa84a-469b-42c3-a6f2-9ee4276b2e40")//education
                },
                new LinkTag {
                    LinkId = Guid.Parse("1a627430-6cef-4a81-88f2-79ee9adfcb12"),//know your rights
                    TagId = Guid.Parse("cbbc812e-3cab-42b9-aeca-f91cf21194c1")//covid
                },
                new LinkTag {
                    LinkId = Guid.Parse("1a627430-6cef-4a81-88f2-79ee9adfcb12"),
                    TagId = Guid.Parse("61d18801-8587-4763-862d-1dc0c69d831a")//employment
                },
                new LinkTag {
                    LinkId = Guid.Parse("1a627430-6cef-4a81-88f2-79ee9adfcb12"),
                    TagId = Guid.Parse("545a3223-1a97-43a2-ae74-60ff4dd2b7ec")//family
                },
                new LinkTag {
                    LinkId = Guid.Parse("1a627430-6cef-4a81-88f2-79ee9adfcb12"),
                    TagId = Guid.Parse("aacd600b-0eeb-4a52-b147-0f209549885f")//children
                },
                new LinkTag {
                    LinkId = Guid.Parse("1a627430-6cef-4a81-88f2-79ee9adfcb12"),
                    TagId = Guid.Parse("2a8f120d-fb1c-4cf8-8f2b-65179bfe59fc")//article
                },
                new LinkTag {
                    LinkId = Guid.Parse("1a627430-6cef-4a81-88f2-79ee9adfcb12"),
                    TagId = Guid.Parse("e9c19fff-b42b-49d1-8309-02ae412a60de")//keiki
                },
                new LinkTag {
                    LinkId = Guid.Parse("fc13c569-da0c-4f19-bba0-f1491850d3d4"),//wakelet
                    TagId = Guid.Parse("b659c2e0-f7e9-4258-a628-1e108831ddf0")//learning
                },
                new LinkTag {
                    LinkId = Guid.Parse("fc13c569-da0c-4f19-bba0-f1491850d3d4"),
                    TagId = Guid.Parse("e1683932-78a2-4ded-a23b-7729573aceca")//wakelet
                },
                new LinkTag {
                    LinkId = Guid.Parse("fc13c569-da0c-4f19-bba0-f1491850d3d4"),
                    TagId = Guid.Parse("9a608f65-9834-47d9-85ce-2818907b0a3b")//home
                },
                new LinkTag {
                    LinkId = Guid.Parse("fc13c569-da0c-4f19-bba0-f1491850d3d4"),
                    TagId = Guid.Parse("f0d0e2f7-f03c-46df-8a6a-4e94cf4dce55")//pre-k
                },
                new LinkTag {
                    LinkId = Guid.Parse("fc13c569-da0c-4f19-bba0-f1491850d3d4"),
                    TagId = Guid.Parse("e9c19fff-b42b-49d1-8309-02ae412a60de")//keiki
                },
                new LinkTag {
                    LinkId = Guid.Parse("fc13c569-da0c-4f19-bba0-f1491850d3d4"),
                    TagId = Guid.Parse("8debb346-fef6-44d3-baa8-37a0a12291a0")//parenting
                },
                new LinkTag {
                    LinkId = Guid.Parse("fc13c569-da0c-4f19-bba0-f1491850d3d4"),
                    TagId = Guid.Parse("aacd600b-0eeb-4a52-b147-0f209549885f")//children
                },
                new LinkTag {
                    LinkId = Guid.Parse("fc13c569-da0c-4f19-bba0-f1491850d3d4"),
                    TagId = Guid.Parse("545a3223-1a97-43a2-ae74-60ff4dd2b7ec")//family
                },
                new LinkTag {
                    LinkId = Guid.Parse("ea94b18d-7c05-4e13-93ab-ab448452991e"),//spatial reasoning
                    TagId = Guid.Parse("aba5e721-d45c-4da5-b9f7-6dab5bab3298")//spatial
                },
                new LinkTag {
                    LinkId = Guid.Parse("ea94b18d-7c05-4e13-93ab-ab448452991e"),
                    TagId = Guid.Parse("12abccf4-937a-48b4-8cfc-eacdc2eb4358")//reasoning
                },
                new LinkTag {
                    LinkId = Guid.Parse("ea94b18d-7c05-4e13-93ab-ab448452991e"),
                    TagId = Guid.Parse("233091f1-0bc4-402f-aca0-a64e057322f8")//DREME
                },
                new LinkTag {
                    LinkId = Guid.Parse("ea94b18d-7c05-4e13-93ab-ab448452991e"),
                    TagId = Guid.Parse("958fa84a-469b-42c3-a6f2-9ee4276b2e40")//education
                },
                new LinkTag {
                    LinkId = Guid.Parse("ea94b18d-7c05-4e13-93ab-ab448452991e"),
                    TagId = Guid.Parse("b659c2e0-f7e9-4258-a628-1e108831ddf0")//learning
                },
                new LinkTag {
                    LinkId = Guid.Parse("ea94b18d-7c05-4e13-93ab-ab448452991e"),
                    TagId = Guid.Parse("bc289b4d-20e1-4696-a55f-ac9023161b31")//math
                },
                new LinkTag {
                    LinkId = Guid.Parse("ea94b18d-7c05-4e13-93ab-ab448452991e"),
                    TagId = Guid.Parse("aacd600b-0eeb-4a52-b147-0f209549885f")//children
                },
                new LinkTag {
                    LinkId = Guid.Parse("ea94b18d-7c05-4e13-93ab-ab448452991e"),
                    TagId = Guid.Parse("e9c19fff-b42b-49d1-8309-02ae412a60de")//keiki
                },
                new LinkTag {
                    LinkId = Guid.Parse("ea94b18d-7c05-4e13-93ab-ab448452991e"),
                    TagId = Guid.Parse("9a608f65-9834-47d9-85ce-2818907b0a3b")//home
                },
                new LinkTag {
                    LinkId = Guid.Parse("8356106d-f708-48fb-9499-cf0dd3b677c5"),//youth and summer camps
                    TagId = Guid.Parse("d416b04b-83b2-4f36-83bf-5b7fa817ee2c")//childcare
                },
                new LinkTag {
                    LinkId = Guid.Parse("8356106d-f708-48fb-9499-cf0dd3b677c5"),
                    TagId = Guid.Parse("639f0d3d-61b8-4d41-95e2-c948ce30171d")//camp
                },
                new LinkTag {
                    LinkId = Guid.Parse("8356106d-f708-48fb-9499-cf0dd3b677c5"),
                    TagId = Guid.Parse("639f0d3d-61b8-4d41-95e2-c948ce30171d")//youth
                },
                new LinkTag {
                    LinkId = Guid.Parse("8356106d-f708-48fb-9499-cf0dd3b677c5"),
                    TagId = Guid.Parse("a69946bc-acb4-4f7d-9eb0-7ed4f0ebac40")//cdc
                },
                new LinkTag {
                    LinkId = Guid.Parse("8356106d-f708-48fb-9499-cf0dd3b677c5"),
                    TagId = Guid.Parse("a48f9a90-f6a0-4f83-9750-b1ab9540a901")//coronavirus
                },
                new LinkTag {
                    LinkId = Guid.Parse("8356106d-f708-48fb-9499-cf0dd3b677c5"),
                    TagId = Guid.Parse("e9c19fff-b42b-49d1-8309-02ae412a60de")//keiki
                },
                new LinkTag {
                    LinkId = Guid.Parse("8356106d-f708-48fb-9499-cf0dd3b677c5"),
                    TagId = Guid.Parse("958fa84a-469b-42c3-a6f2-9ee4276b2e40")//education
                },
                new LinkTag {
                    LinkId = Guid.Parse("3334b097-20a9-453f-9ef7-919432abeb64"),//talk about numbers
                    TagId = Guid.Parse("233091f1-0bc4-402f-aca0-a64e057322f8")//DREME
                },
                new LinkTag {
                    LinkId = Guid.Parse("3334b097-20a9-453f-9ef7-919432abeb64"),
                    TagId = Guid.Parse("958fa84a-469b-42c3-a6f2-9ee4276b2e40")//education
                },
                new LinkTag {
                    LinkId = Guid.Parse("3334b097-20a9-453f-9ef7-919432abeb64"),
                    TagId = Guid.Parse("aacd600b-0eeb-4a52-b147-0f209549885f")//children
                },
                new LinkTag {
                    LinkId = Guid.Parse("3334b097-20a9-453f-9ef7-919432abeb64"),
                    TagId = Guid.Parse("e9c19fff-b42b-49d1-8309-02ae412a60de")//keiki
                },
                new LinkTag {
                    LinkId = Guid.Parse("3334b097-20a9-453f-9ef7-919432abeb64"),
                    TagId = Guid.Parse("545a3223-1a97-43a2-ae74-60ff4dd2b7ec")//family
                },
                new LinkTag {
                    LinkId = Guid.Parse("a8369011-960d-41e1-ab81-111106be561e"),//learningtogrow
                    TagId = Guid.Parse("233091f1-0bc4-402f-aca0-a64e057322f8")//DREME
                },
                new LinkTag {
                    LinkId = Guid.Parse("a8369011-960d-41e1-ab81-111106be561e"),
                    TagId = Guid.Parse("b659c2e0-f7e9-4258-a628-1e108831ddf0")//learning
                },
                new LinkTag {
                    LinkId = Guid.Parse("a8369011-960d-41e1-ab81-111106be561e"),
                    TagId = Guid.Parse("5391b3cc-31be-4ed7-906b-969a08e11ac3")//grow
                },
                new LinkTag {
                    LinkId = Guid.Parse("a8369011-960d-41e1-ab81-111106be561e"),
                    TagId = Guid.Parse("13c0cc5f-ad64-40bc-90b7-502e92e3d5c0")//hawaii
                },
                new LinkTag {
                    LinkId = Guid.Parse("a8369011-960d-41e1-ab81-111106be561e"),
                    TagId = Guid.Parse("bc289b4d-20e1-4696-a55f-ac9023161b31")//math
                },
                new LinkTag {
                    LinkId = Guid.Parse("a8369011-960d-41e1-ab81-111106be561e"),
                    TagId = Guid.Parse("87c3dfd2-eb9c-474c-bc20-d2586eff3fe2")//activities
                },
                new LinkTag {
                    LinkId = Guid.Parse("a8369011-960d-41e1-ab81-111106be561e"),
                    TagId = Guid.Parse("b5afce52-fa3f-4edd-825f-ed59412143cf")//infant
                },
                new LinkTag {
                    LinkId = Guid.Parse("a8369011-960d-41e1-ab81-111106be561e"),
                    TagId = Guid.Parse("4e4e0759-c9b0-47e7-9782-99a8e1cd601e")//toddler
                },
                new LinkTag {
                    LinkId = Guid.Parse("a8369011-960d-41e1-ab81-111106be561e"),
                    TagId = Guid.Parse("9a608f65-9834-47d9-85ce-2818907b0a3b")//home
                },
                new LinkTag {
                    LinkId = Guid.Parse("4eb39313-02a6-4139-93e5-b39609fc4167"),//early math learning
                    TagId = Guid.Parse("233091f1-0bc4-402f-aca0-a64e057322f8")//DREME
                },
                new LinkTag {
                    LinkId = Guid.Parse("4eb39313-02a6-4139-93e5-b39609fc4167"),
                    TagId = Guid.Parse("6df13233-ad61-45ff-942b-1857da99c0f1")//skills
                },
                new LinkTag {
                    LinkId = Guid.Parse("4eb39313-02a6-4139-93e5-b39609fc4167"),
                    TagId = Guid.Parse("bc289b4d-20e1-4696-a55f-ac9023161b31")//math
                },
                new LinkTag {
                    LinkId = Guid.Parse("4eb39313-02a6-4139-93e5-b39609fc4167"),
                    TagId = Guid.Parse("958fa84a-469b-42c3-a6f2-9ee4276b2e40")//education
                },
                new LinkTag {
                    LinkId = Guid.Parse("4eb39313-02a6-4139-93e5-b39609fc4167"),
                    TagId = Guid.Parse("b659c2e0-f7e9-4258-a628-1e108831ddf0")//learning
                },
                new LinkTag {
                    LinkId = Guid.Parse("4eb39313-02a6-4139-93e5-b39609fc4167"),
                    TagId = Guid.Parse("9a608f65-9834-47d9-85ce-2818907b0a3b")//home
                },
                new LinkTag {
                    LinkId = Guid.Parse("9a848840-6c03-4df8-bfb4-1122c8400c06"),//finding care for your child
                    TagId = Guid.Parse("a8fd4501-4100-497b-8a17-8ddba4fd7886")//eoel
                },
                new LinkTag {
                    LinkId = Guid.Parse("9a848840-6c03-4df8-bfb4-1122c8400c06"),
                    TagId = Guid.Parse("3c85333d-03ce-4eea-b8f1-273a24cad04b")//care
                },
                new LinkTag {
                    LinkId = Guid.Parse("9a848840-6c03-4df8-bfb4-1122c8400c06"),
                    TagId = Guid.Parse("545a3223-1a97-43a2-ae74-60ff4dd2b7ec")//family
                },
                new LinkTag {
                    LinkId = Guid.Parse("9a848840-6c03-4df8-bfb4-1122c8400c06"),
                    TagId = Guid.Parse("a48f9a90-f6a0-4f83-9750-b1ab9540a901")//coronavirus
                },
                new LinkTag {
                    LinkId = Guid.Parse("9a848840-6c03-4df8-bfb4-1122c8400c06"),
                    TagId = Guid.Parse("9a608f65-9834-47d9-85ce-2818907b0a3b")//home
                },
                new LinkTag {
                    LinkId = Guid.Parse("4190e202-1477-40a2-935a-d85ba55d713a"),//athome resources for families
                    TagId = Guid.Parse("a8fd4501-4100-497b-8a17-8ddba4fd7886")//eoel
                },
                new LinkTag {
                    LinkId = Guid.Parse("4190e202-1477-40a2-935a-d85ba55d713a"),
                    TagId = Guid.Parse("3c85333d-03ce-4eea-b8f1-273a24cad04b")//care
                },
                new LinkTag {
                    LinkId = Guid.Parse("4190e202-1477-40a2-935a-d85ba55d713a"),
                    TagId = Guid.Parse("9a608f65-9834-47d9-85ce-2818907b0a3b")//home
                },
                new LinkTag {
                    LinkId = Guid.Parse("4190e202-1477-40a2-935a-d85ba55d713a"),
                    TagId = Guid.Parse("545a3223-1a97-43a2-ae74-60ff4dd2b7ec")//family
                },
                new LinkTag {
                    LinkId = Guid.Parse("4190e202-1477-40a2-935a-d85ba55d713a"),
                    TagId = Guid.Parse("a48f9a90-f6a0-4f83-9750-b1ab9540a901")//coronavirus
                },
                new LinkTag {
                    LinkId = Guid.Parse("4190e202-1477-40a2-935a-d85ba55d713a"),
                    TagId = Guid.Parse("cc857f6e-0f23-481a-8a21-19164e6414f1")//covid-19
                },
                new LinkTag {
                    LinkId = Guid.Parse("96c7a4ef-43d0-4d89-a3c9-5a3974f36533"),//cdc dev milestones for infants
                    TagId = Guid.Parse("a8fd4501-4100-497b-8a17-8ddba4fd7886")//eoel
                },
                new LinkTag {
                    LinkId = Guid.Parse("96c7a4ef-43d0-4d89-a3c9-5a3974f36533"),
                    TagId = Guid.Parse("3c85333d-03ce-4eea-b8f1-273a24cad04b")//care
                },
                new LinkTag {
                    LinkId = Guid.Parse("96c7a4ef-43d0-4d89-a3c9-5a3974f36533"),
                    TagId = Guid.Parse("9a608f65-9834-47d9-85ce-2818907b0a3b")//home
                },
                new LinkTag {
                    LinkId = Guid.Parse("96c7a4ef-43d0-4d89-a3c9-5a3974f36533"),
                    TagId = Guid.Parse("545a3223-1a97-43a2-ae74-60ff4dd2b7ec")//family
                },
                new LinkTag {
                    LinkId = Guid.Parse("96c7a4ef-43d0-4d89-a3c9-5a3974f36533"),
                    TagId = Guid.Parse("a48f9a90-f6a0-4f83-9750-b1ab9540a901")//coronavirus
                },
                new LinkTag {
                    LinkId = Guid.Parse("96c7a4ef-43d0-4d89-a3c9-5a3974f36533"),
                    TagId = Guid.Parse("cc857f6e-0f23-481a-8a21-19164e6414f1")//covid-19
                },
                new LinkTag {
                    LinkId = Guid.Parse("96c7a4ef-43d0-4d89-a3c9-5a3974f36533"),
                    TagId = Guid.Parse("ac00b15c-a093-483a-bc71-76f18843c2dc")//milestone
                },
                new LinkTag {
                    LinkId = Guid.Parse("0ce04084-dcb1-4250-8d7c-a73385cbb76d"),//coding with children
                    TagId = Guid.Parse("55e88610-b070-42aa-8c99-533b2b881b05")//coding
                },
                new LinkTag {
                    LinkId = Guid.Parse("0ce04084-dcb1-4250-8d7c-a73385cbb76d"),
                    TagId = Guid.Parse("aacd600b-0eeb-4a52-b147-0f209549885f")//children
                },
                new LinkTag {
                    LinkId = Guid.Parse("0ce04084-dcb1-4250-8d7c-a73385cbb76d"),
                    TagId = Guid.Parse("e9c19fff-b42b-49d1-8309-02ae412a60de")//keiki
                },
                new LinkTag {
                    LinkId = Guid.Parse("0ce04084-dcb1-4250-8d7c-a73385cbb76d"),
                    TagId = Guid.Parse("b659c2e0-f7e9-4258-a628-1e108831ddf0")//learning
                },
                new LinkTag {
                    LinkId = Guid.Parse("0ce04084-dcb1-4250-8d7c-a73385cbb76d"),
                    TagId = Guid.Parse("958fa84a-469b-42c3-a6f2-9ee4276b2e40")//education
                },
                new LinkTag {
                    LinkId = Guid.Parse("fe7a07aa-7456-481a-971d-fcc0a65fb34e"),//childrens museum
                    TagId = Guid.Parse("aacd600b-0eeb-4a52-b147-0f209549885f")//children
                },
                new LinkTag {
                    LinkId = Guid.Parse("fe7a07aa-7456-481a-971d-fcc0a65fb34e"),
                    TagId = Guid.Parse("9be2b66e-aacd-4110-b937-87e7de68aae9")//museum
                },
                new LinkTag {
                    LinkId = Guid.Parse("fe7a07aa-7456-481a-971d-fcc0a65fb34e"),
                    TagId = Guid.Parse("9a608f65-9834-47d9-85ce-2818907b0a3b")//home
                },
                new LinkTag {
                    LinkId = Guid.Parse("fe7a07aa-7456-481a-971d-fcc0a65fb34e"),
                    TagId = Guid.Parse("87c3dfd2-eb9c-474c-bc20-d2586eff3fe2")//activities
                },
                new LinkTag {
                    LinkId = Guid.Parse("1ccf53a1-ceb8-43cd-beb1-27efbdc8f25e"),//fit with sohi
                    TagId = Guid.Parse("021fcffe-e6d7-4f68-810b-2330116331b3")//fit
                },
                new LinkTag {
                    LinkId = Guid.Parse("1ccf53a1-ceb8-43cd-beb1-27efbdc8f25e"),
                    TagId = Guid.Parse("244c117c-e184-473b-9131-02fc45d1b4e5")//special
                },
                new LinkTag {
                    LinkId = Guid.Parse("1ccf53a1-ceb8-43cd-beb1-27efbdc8f25e"),
                    TagId = Guid.Parse("fcc2ef68-57e6-4114-ad5f-cf3fb81e89a0")//olympic
                },
                new LinkTag {
                    LinkId = Guid.Parse("1ccf53a1-ceb8-43cd-beb1-27efbdc8f25e"),
                    TagId = Guid.Parse("13c0cc5f-ad64-40bc-90b7-502e92e3d5c0")//hawaii
                },
                new LinkTag {
                    LinkId = Guid.Parse("0eba1889-edc2-48c1-a5eb-45fc773e192c"),//uclamp math at home
                    TagId = Guid.Parse("bc289b4d-20e1-4696-a55f-ac9023161b31")//math
                },
                new LinkTag {
                    LinkId = Guid.Parse("0eba1889-edc2-48c1-a5eb-45fc773e192c"),
                    TagId = Guid.Parse("b659c2e0-f7e9-4258-a628-1e108831ddf0")//learning
                },
                new LinkTag {
                    LinkId = Guid.Parse("0eba1889-edc2-48c1-a5eb-45fc773e192c"),
                    TagId = Guid.Parse("9a608f65-9834-47d9-85ce-2818907b0a3b")//home
                },
                new LinkTag {
                    LinkId = Guid.Parse("0eba1889-edc2-48c1-a5eb-45fc773e192c"),
                    TagId = Guid.Parse("958fa84a-469b-42c3-a6f2-9ee4276b2e40")//education
                },
                new LinkTag {
                    LinkId = Guid.Parse("0eba1889-edc2-48c1-a5eb-45fc773e192c"),
                    TagId = Guid.Parse("aacd600b-0eeb-4a52-b147-0f209549885f")//children
                },
                new LinkTag {
                    LinkId = Guid.Parse("0eba1889-edc2-48c1-a5eb-45fc773e192c"),
                    TagId = Guid.Parse("87c3dfd2-eb9c-474c-bc20-d2586eff3fe2")//activities
                }
            );
        }
    }
}