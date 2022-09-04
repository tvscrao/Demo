using Moq;
using Xunit;

namespace Demo.Test
{
    public class QueryTest
    {
        #region Initialize Mock objects 
        public Mock<IQueryService> mockQueryService = new Mock<IQueryService>();
        public Mock<IHttpClientFactory> mockClientFactory = new Mock<IHttpClientFactory>();
        #endregion
         
        #region GetPeople Tests

        [Fact]
        public void GetPeople_Should_Return_Value()
        {  
            // Arrange
            IQueryBase query = new Query(mockClientFactory.Object, mockQueryService.Object); 
            mockQueryService.Setup(p => p.GetPeopleAsync()).ReturnsAsync(TestData.GetPeople().Result);
            
            // Act
            var result = query.GetPeople();
            
            // Assert
            Assert.NotNull(result);
        }

        #endregion

        #region GetPeopleById Tests
        [Fact]
        public void GetPeopleById_Should_Return_Value()
        {   
            // Arrange
            IQueryBase query = new Query(mockClientFactory.Object, mockQueryService.Object); 
            mockQueryService.Setup(p => p.GetPeopleByIdAsync(1)).ReturnsAsync(TestData.GetPeopleById(1).Result);

            // Act
            var result = query.GetPeopleById(1);

            // Assert
            Assert.NotNull(result);
        }
        #endregion
    }
}