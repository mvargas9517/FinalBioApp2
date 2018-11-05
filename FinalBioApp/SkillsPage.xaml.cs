using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace FinalBioApp
{
    public partial class SkillsPage : ContentPage
    {
        public ObservableCollection<Skill> Skills { get; set; }

        public SkillsPage()
        {
            InitializeComponent();

            this.Skills = new ObservableCollection<Skill>();

            this.Skills.Add(new Skill 
            { Description = "Building Quieries in SQL", Name = "SQL" , Icon ="SQL.png"});
            this.Skills.Add(new Skill 
            { Description = "Can work all MS Office", Name = "MS Office", Icon ="MSOffice.jpg" });
            this.Skills.Add(new Skill 
            { Description = "Can desing in CSS", Name = "CSS", Icon="CSS.png" });
            this.Skills.Add(new Skill 
            { Description = "Can build websites with HTML", Name = "HTML", Icon="HTML.png" });
            this.Skills.Add(new Skill 
            { Description = "Can build Mockups in XD", Name = "Adobe XD", Icon="XD.png" });
            this.Skills.Add(new Skill 
            { Description = "Coding in Javascript", Name = "Javascript", Icon="Javascript.jpg" });

            SkillsListView.ItemsSource = this.Skills;
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new StartPage());
        }
        void Bio_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new MyPage());
        }
        void Contact_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new ContactPage());
        }
        public class Skill
        {
            public string Name { get; set; }

            public string Description { get; set; }

            public string Icon { get; set; }
        }
    }
}
