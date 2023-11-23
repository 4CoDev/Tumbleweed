namespace Tumbleweed.Subroutine.Function.Unary;

public interface Any<in Parameter, out Result>
{
	Result ResultWith(Parameter parameter);
}