namespace Tumbleweed.Subroutine.Procedure.Unary;

public interface Any<in T>
{
	void InvokeWith(T parameter);
}