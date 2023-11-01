using Output = Tumbleweed.Property.Output;
using Input = Tumbleweed.Property.Input;

namespace Tumbleweed.Property.Transput;

public interface Any<T> : Output::Any<T>, Input::Any<T>
{
	new T Value { get; set; }
}