using MCExcercises;
using System;
using Xunit;

namespace MCETests
{
    public class UnitTest1
    {
        [Fact]
        public void Task1_BAONXXOLLBAONXXOLL_2()
        {

            const int result = 2;

            //Act
            var Test1 = Task1.solution("BAONXXOLLBAONXXOLL");

            //Assert
            Assert.Equal(Test1, result);
        }
        [Fact]
        public void Task1_nlaebolko_0()
        {
            const int result = 0;

            //Act
            var Test1 = Task1.solution("nlaebolko");

            //Assert
            Assert.Equal(Test1, result);
        }
        [Fact]
        public void Task1_loonbalxballpoon_0()
        {
            const int result = 0;

            //Act
            var Test1 = Task1.solution("loonbalxballpoon");

            //Assert
            Assert.Equal(Test1, result);
        }
        [Fact]
        public void Task1_BAONXXOLL_1()
        {
            const int result = 1;

            //Act
            var Test1 = Task1.solution("BAONXXOLL");

            //Assert
            Assert.Equal(Test1, result);
        }
    }
}
