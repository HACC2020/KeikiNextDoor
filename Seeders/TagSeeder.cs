using System;

using Microsoft.EntityFrameworkCore;

using OhanaSupport.Models;

namespace OhanaSupport.Seeders {
    public class TagSeeder {
        public void Seed(ModelBuilder modelBuilder){
            modelBuilder.Entity<Tag>().HasData(
                new Tag {
                    Id = Guid.Parse("cbbc812e-3cab-42b9-aeca-f91cf21194c1"),
                    Text = "COVID"
                },
                new Tag {
                    Id = Guid.Parse("a8fd4501-4100-497b-8a17-8ddba4fd7886"),
                    Text = "EOEL"
                },
                new Tag {
                    Id = Guid.Parse("37b9e987-6a33-4514-a6d2-835903743369"),
                    Text = "Homepage"
                },
                new Tag {
                    Id = Guid.Parse("545a3223-1a97-43a2-ae74-60ff4dd2b7ec"),
                    Text = "Family"
                },
                new Tag {
                    Id = Guid.Parse("9cb56da2-a1a1-4f5a-bf76-5392d0a9b049"),
                    Text = "Resource"
                },
                new Tag {
                    Id = Guid.Parse("3d5838f2-4fff-4350-8de1-b6041ef68c9a"),
                    Text = "Scholarship"
                },
                new Tag {
                    Id = Guid.Parse("2d6c9fcb-a933-4912-a16c-4ad290777cb8"),
                    Text = "Subsidy"
                },
                new Tag {
                    Id = Guid.Parse("890985c5-b423-4fd4-bf40-91aa9bd2e5dc"),
                    Text = "Hawaiian"
                },
                new Tag {
                    Id = Guid.Parse("d416b04b-83b2-4f36-83bf-5b7fa817ee2c"),
                    Text = "Childcare"
                },
                new Tag {
                    Id = Guid.Parse("48d069a2-9c39-4665-9485-22e4b56a7972"),
                    Text = "Pauahi"
                },
                new Tag {
                    Id = Guid.Parse("e9c19fff-b42b-49d1-8309-02ae412a60de"),
                    Text = "Keiki"
                },
                new Tag {
                    Id = Guid.Parse("aacd600b-0eeb-4a52-b147-0f209549885f"),
                    Text = "Children"
                },
                new Tag {
                    Id = Guid.Parse("19ccee14-002c-4bd0-a205-caa0c6acbe36"),
                    Text = "Aid"
                },
                new Tag {
                    Id = Guid.Parse("96bd77d3-3448-4fb8-88ff-80eed4e40737"),
                    Text = "Finance"
                },
                new Tag {
                    Id = Guid.Parse("9507c750-c643-47a7-90d3-46633c16c237"),
                    Text = "Eligibility"
                },
                new Tag {
                    Id = Guid.Parse("cc857f6e-0f23-481a-8a21-19164e6414f1"),
                    Text = "Covid-19"
                },
                new Tag {
                    Id = Guid.Parse("7a59d506-1192-47b3-a46d-6ec3a7f88664"),
                    Text = "Survey"
                },
                new Tag {
                    Id = Guid.Parse("dc97a1f5-a068-4ea9-8513-84564acac4c1"),
                    Text = "Service"
                },
                new Tag {
                    Id = Guid.Parse("ecf04aee-4f83-4631-998d-f398684a1824"),
                    Text = "Support"
                },
                new Tag {
                    Id = Guid.Parse("dc31bb70-1d06-4b28-9ba8-308a56ee9209"),
                    Text = "Maui"
                },
                new Tag {
                    Id = Guid.Parse("b7bb539f-fa0e-4234-8f67-32a03b43e5f7"),
                    Text = "Transitioning"
                },
                new Tag {
                    Id = Guid.Parse("2a8f120d-fb1c-4cf8-8f2b-65179bfe59fc"),
                    Text = "Article"
                },
                new Tag {
                    Id = Guid.Parse("f8a509cd-c12e-4122-ba76-1735d36facee"),
                    Text = "Caregiver"
                },
                new Tag {
                    Id = Guid.Parse("23e31995-07e9-4ef1-a79c-297d29e5c8dd"),
                    Text = "Masks"
                },
                new Tag {
                    Id = Guid.Parse("61d18801-8587-4763-862d-1dc0c69d831a"),
                    Text = "Employment"
                },
                new Tag {
                    Id = Guid.Parse("13c0cc5f-ad64-40bc-90b7-502e92e3d5c0"),
                    Text = "Hawaii"
                },
                new Tag {
                    Id = Guid.Parse("4acaf4bd-8b6c-4f99-aa82-9baaa28a0740"),
                    Text = "Honolulu"
                },
                new Tag {
                    Id = Guid.Parse("a01dd380-0986-4b18-8e90-523f64fe815b"),
                    Text = "County"
                },
                new Tag {
                    Id = Guid.Parse("382167e3-7ce7-4422-8c80-e4b2c18934c0"),
                    Text = "Kauai"
                },
                new Tag {
                    Id = Guid.Parse("a48f9a90-f6a0-4f83-9750-b1ab9540a901"),
                    Text = "Coronavirus"
                },
                new Tag {
                    Id = Guid.Parse("28c18b22-4699-4df3-8ac5-b76b13f3cd1b"),
                    Text = "Response"
                },
                new Tag {
                    Id = Guid.Parse("639f0d3d-61b8-4d41-95e2-c948ce30171d"),
                    Text = "Camp"
                },
                new Tag {
                    Id = Guid.Parse("3c85333d-03ce-4eea-b8f1-273a24cad04b"),
                    Text = "Care"
                },
                new Tag {
                    Id = Guid.Parse("cfba8acf-e9fb-4a5b-aaff-383636379268"),
                    Text = "Tool"
                },
                new Tag {
                    Id = Guid.Parse("9a608f65-9834-47d9-85ce-2818907b0a3b"),
                    Text = "Home"
                },
                new Tag {
                    Id = Guid.Parse("a69946bc-acb4-4f7d-9eb0-7ed4f0ebac40"),
                    Text = "CDC"
                },
                new Tag {
                    Id = Guid.Parse("b5afce52-fa3f-4edd-825f-ed59412143cf"),
                    Text = "Infant"
                },
                new Tag {
                    Id = Guid.Parse("4e4e0759-c9b0-47e7-9782-99a8e1cd601e"),
                    Text = "Toddler"
                },
                new Tag {
                    Id = Guid.Parse("8da99e93-ba60-40de-89f0-9032e0a5631b"),
                    Text = "Parent"
                },
                new Tag {
                    Id = Guid.Parse("cd0ada9b-9c35-45ed-b7fc-14079c01ffa7"),
                    Text = "Babies"
                },
                new Tag {
                    Id = Guid.Parse("87c3dfd2-eb9c-474c-bc20-d2586eff3fe2"),
                    Text = "Activities"
                },
                new Tag {
                    Id = Guid.Parse("90e3d0f5-0487-467d-aee2-478378bff623"),
                    Text = "Early"
                },
                new Tag {
                    Id = Guid.Parse("b659c2e0-f7e9-4258-a628-1e108831ddf0"),
                    Text = "Learning"
                },
                new Tag {
                    Id = Guid.Parse("8debb346-fef6-44d3-baa8-37a0a12291a0"),
                    Text = "Parenting"
                },
                new Tag {
                    Id = Guid.Parse("bc289b4d-20e1-4696-a55f-ac9023161b31"),
                    Text = "Math"
                },
                new Tag {
                    Id = Guid.Parse("55e88610-b070-42aa-8c99-533b2b881b05"),
                    Text = "Coding"
                },
                new Tag {
                    Id = Guid.Parse("09c743bf-7461-4f43-a671-9966d03b9d0c"),
                    Text = "Tips"
                },
                new Tag {
                    Id = Guid.Parse("233a88ca-3452-4b7b-89d3-efb6fe405316"),
                    Text = "Advice"
                },
                new Tag {
                    Id = Guid.Parse("6df13233-ad61-45ff-942b-1857da99c0f1"),
                    Text = "Skills"
                },
                new Tag {
                    Id = Guid.Parse("9e7303bc-730a-4d5c-a110-57029ffd7ff4"),
                    Text = "Schedule"
                },
                new Tag {
                    Id = Guid.Parse("a7f9abec-e209-4a5c-99e3-bdb3a679a2f7"),
                    Text = "Routine"
                },
                new Tag {
                    Id = Guid.Parse("a6ce6fc1-ebf4-4286-80da-fccf5aa60266"),
                    Text = "Lahui"
                },
                new Tag {
                    Id = Guid.Parse("344c0405-f0b9-408e-ae56-063bfa06d705"),
                    Text = "Federal"
                },
                new Tag {
                    Id = Guid.Parse("381184be-55af-4f55-9fd5-94a5c5864582"),
                    Text = "Government"
                },
                new Tag {
                    Id = Guid.Parse("40f84a57-8260-47c3-8e53-55f5c67719c6"),
                    Text = "Corona"
                },
                new Tag {
                    Id = Guid.Parse("3a06d804-0635-4cd0-81ca-4dbcab0e5c40"),
                    Text = "State"
                },
                new Tag {
                    Id = Guid.Parse("63bd4a10-d00f-4d3e-a913-c2b1eb00ca1c"),
                    Text = "Old"
                },
                new Tag {
                    Id = Guid.Parse("7319b1f7-e0ef-49b7-9cc2-b73c3e79f5eb"),
                    Text = "Year"
                },
                new Tag {
                    Id = Guid.Parse("bd2bbdb1-379d-4fdc-b7bb-27b2a1770c4c"),
                    Text = "Schedule"
                },
                new Tag {
                    Id = Guid.Parse("f0d0e2f7-f03c-46df-8a6a-4e94cf4dce55"),
                    Text = "Pre-K"
                },
                new Tag {
                    Id = Guid.Parse("244c117c-e184-473b-9131-02fc45d1b4e5"),
                    Text = "Special"
                },
                new Tag {
                    Id = Guid.Parse("b7cc1c6f-ca92-4c00-b899-cdc0aba0590b"),
                    Text = "Department"
                },
                new Tag {
                    Id = Guid.Parse("45e34501-421a-4ba3-85d2-b07eb71c3f5c"),
                    Text = "Health"
                },
                new Tag {
                    Id = Guid.Parse("df91bd45-cc8c-458f-9079-b20b65ec5caf"),
                    Text = "Guideline"
                },
                new Tag {
                    Id = Guid.Parse("fcc2ef68-57e6-4114-ad5f-cf3fb81e89a0"),
                    Text = "Olympic"
                },
                new Tag {
                    Id = Guid.Parse("021fcffe-e6d7-4f68-810b-2330116331b3"),
                    Text = "Fit"
                },
                new Tag {
                    Id = Guid.Parse("40b4e33f-1859-45fe-b6c7-7ee7eac6e337"),
                    Text = "Page"
                },
                new Tag {
                    Id = Guid.Parse("5391b3cc-31be-4ed7-906b-969a08e11ac3"),
                    Text = "Grow"
                },
                new Tag {
                    Id = Guid.Parse("e3df4bb9-eda1-4896-a72b-1ecb66b55779"),
                    Text = "Number"
                },
                new Tag {
                    Id = Guid.Parse("0e3ce281-5d28-40f5-b34e-43ff5dc07b16"),
                    Text = "Talk"
                },
                new Tag {
                    Id = Guid.Parse("aba5e721-d45c-4da5-b9f7-6dab5bab3298"),
                    Text = "Spatial"
                },
                new Tag {
                    Id = Guid.Parse("12abccf4-937a-48b4-8cfc-eacdc2eb4358"),
                    Text = "Reasoning"
                },
                new Tag {
                    Id = Guid.Parse("e1683932-78a2-4ded-a23b-7729573aceca"),
                    Text = "Wakelet"
                },
                new Tag {
                    Id = Guid.Parse("ac585b09-b9a3-438f-8f8e-73b9f16fe597"),
                    Text = "Update"
                },
                new Tag {
                    Id = Guid.Parse("b22ec78a-cfb1-4278-905d-857b79f7fa0b"),
                    Text = "Handwashing"
                },
                new Tag {
                    Id = Guid.Parse("cf0def79-5b99-4754-a775-b76f14f3bbe4"),
                    Text = "Culture"
                },
                new Tag {
                    Id = Guid.Parse("8bb5da12-bd2f-4357-bfd3-7628ff23ac81"),
                    Text = "Virtual"
                },
                new Tag {
                    Id = Guid.Parse("a39d1527-8d4f-4ff8-bcbf-c3458de5588e"),
                    Text = "Checklist"
                },
                new Tag {
                    Id = Guid.Parse("6dc7eabd-f824-457f-a738-9bac58b5604b"),
                    Text = "Teacher"
                },
                new Tag {
                    Id = Guid.Parse("9cfce7ee-c57a-476c-86fd-fd87a13dd573"),
                    Text = "Trip"
                },
                new Tag {
                    Id = Guid.Parse("d41b6b30-ecd0-4a5d-bd45-4ecabd20011b"),
                    Text = "Website"
                },
                new Tag {
                    Id = Guid.Parse("8606f298-1d23-4001-9115-cb487dd96e77"),
                    Text = "Field"
                },
                new Tag {
                    Id = Guid.Parse("3169bb2b-b752-4a1a-bdcb-294c8a080979"),
                    Text = "Foundation"
                },
                new Tag {
                    Id = Guid.Parse("9be2b66e-aacd-4110-b937-87e7de68aae9"),
                    Text = "Museum"
                },
                new Tag {
                    Id = Guid.Parse("233091f1-0bc4-402f-aca0-a64e057322f8"),
                    Text = "DREME"
                },
                new Tag {
                    Id = Guid.Parse("ac00b15c-a093-483a-bc71-76f18843c2dc"),
                    Text = "Milestone"
                },
                new Tag {
                    Id = Guid.Parse("958fa84a-469b-42c3-a6f2-9ee4276b2e40"),
                    Text = "Education"
                },
                new Tag {
                    Id = Guid.Parse("e9052ff3-f1fa-4792-ab3f-5a25b3686031"),
                    Text = "Proclamation"
                },
                new Tag {
                    Id = Guid.Parse("62025c26-33c8-47b1-919c-acb4191e3280"),
                    Text = "School"
                }
            );
        }
    }
}