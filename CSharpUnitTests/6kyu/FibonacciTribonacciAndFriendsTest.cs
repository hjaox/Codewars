using CSharp._6kyu;

namespace CSharpUnitTests._6kyu;

[TestFixture]
public class FibonacciTribonacciAndFriendsTest {
    [Test]
    public void BasicTests() {
        ClassicAssert.AreEqual(new double []{0,1,1,2,3,5,8,13,21,34}, FibonacciTribonacciAndFriends.Xbonacci(new double []{0,1},10));
        ClassicAssert.AreEqual(new double []{1,1,2,3,5,8,13,21,34,55}, FibonacciTribonacciAndFriends.Xbonacci(new double []{1,1},10));
        ClassicAssert.AreEqual(new double []{0,0,0,0,1,1,2,4,8,16}, FibonacciTribonacciAndFriends.Xbonacci(new double []{0,0,0,0,1},10));
        ClassicAssert.AreEqual(new double []{1,0,0,0,0,0,1,2,3,6}, FibonacciTribonacciAndFriends.Xbonacci(new double []{1,0,0,0,0,0,1},10));
    }
}