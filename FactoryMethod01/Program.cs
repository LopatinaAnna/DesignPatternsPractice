using System;

namespace FactoryMethod01
{
    class Program
    {
        static void Main()
        {
            RenderButton(new WindowsDialog());
            RenderButton(new WebDialog());
        }

        static void RenderButton(DialogFactory dialog)
        {
            Console.WriteLine(dialog.Render());
        }
    }

    interface IButton
    {
        string Render();
    }

    class WebButton : IButton
    {
        public string Render() => "Render a button in Web style.";
    }

    class WindowsButton : IButton
    {
        public string Render() => "Render a button in Windows style.";
    }

    abstract class DialogFactory
    {
        public abstract IButton CreateButton();
        public string Render()
        {
            // Call the factory method to create a button object.
            IButton button = CreateButton();

            return button.Render();
        }
    }

    class WebDialog : DialogFactory
    {
        public override IButton CreateButton()
        {
            return new WebButton();
        }
    }

    class WindowsDialog : DialogFactory
    {
        public override IButton CreateButton()
        {
            return new WindowsButton();
        }
    }
}
