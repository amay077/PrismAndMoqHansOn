using System.Threading.Tasks;
using Microsoft.Pex.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

// ReSharper disable once CheckNamespace
namespace TextSpeaker.ViewModels.Tests
{
    [TestClass]
    public class TextSpeachPageViewModelTest
    {
        [TestMethod]
        public void SpeachTest()
        {
            var viewModel = new TextSpeachPageViewModel();
            viewModel.Speach();
        }
    }
}
