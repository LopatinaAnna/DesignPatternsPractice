using System;
using System.Collections.Generic;

namespace FactoryMethod02
{
    class Program
    {
        static void Main()
        {
            // Constructors call Factory Method
            DocumentFactory[] documents = new DocumentFactory[2];
            documents[0] = new Resume();
            documents[1] = new Report();

            // Display document pages
            foreach (DocumentFactory document in documents)
            {
                Console.WriteLine("\n" + document.GetType().Name + "--");
                foreach (Page page in document.Pages)
                {
                    Console.WriteLine("\t" + page.GetType().Name);
                }
            }
        }
    }

    abstract class Page
    {
    }

    class SkillsPage : Page
    {
    }

    class EducationPage : Page
    {
    }

    class ExperiencePage : Page
    {
    }

    class IntroductionPage : Page
    {
    }

    class ResultsPage : Page
    {
    }

    class ConclusionPage : Page
    {
    }

    class SummaryPage : Page
    {
    }

    class BibliographyPage : Page
    {
    }

    abstract class DocumentFactory
    {
        private List<Page> _pages = new List<Page>();

        // Constructor calls abstract Factory method
        public DocumentFactory()
        {
            this.CreatePages();
        }

        public List<Page> Pages
        {
            get { return _pages; }
        }

        // Factory Method
        public abstract void CreatePages();
    }

    class Resume : DocumentFactory
    {
        // Factory Method implementation
        public override void CreatePages()
        {
            Pages.Add(new SkillsPage());
            Pages.Add(new EducationPage());
            Pages.Add(new ExperiencePage());
        }
    }

    class Report : DocumentFactory
    {
        // Factory Method implementation
        public override void CreatePages()
        {
            Pages.Add(new IntroductionPage());
            Pages.Add(new ResultsPage());
            Pages.Add(new ConclusionPage());
            Pages.Add(new SummaryPage());
            Pages.Add(new BibliographyPage());
        }
    }
}
