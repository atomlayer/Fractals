﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using MusicGenerator.Builder;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestFixture]
    public class NoteSpaceTest
    {
        [Test]
        public void SelectionOfTheMaxSpaceBetweenFilledPartOfSpaceTest()
        {
            Random random = new Random();
            NoteSpace noteSpace = new NoteSpace(20,random);

            PrivateObject privateObject = new PrivateObject(noteSpace);
            int startPart;
            int endPart;
            object obj = privateObject.Invoke("SelectionOfTheMaxSpaceBetweenFilledPartOfSpace", out startPart, out endPart);
            Assert.AreEqual(8, (int)obj); 
        }
    }
}
