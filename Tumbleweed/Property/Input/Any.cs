namespace Tumbleweed.Property.Input;

public interface Any<in T>
{
	T Value { set; }
}