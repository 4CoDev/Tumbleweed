namespace Tumbleweed.Subroutine.Procedure.Binary;

public interface Any<in T1, in T2>
{
	void InvokeWith(T1 first, T2 second);
}