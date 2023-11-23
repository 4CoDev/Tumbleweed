namespace Tumbleweed.Subroutine.Procedure.Binary;

public abstract class Envelope<T1, T2> : Binary.Any<T1, T2>
{
	protected Envelope(Binary.Any<T1, T2> procedure) =>
		this.procedure = procedure;
	
	public void InvokeWith(T1 first, T2 second) =>
		procedure.InvokeWith(first, second);

	private readonly Binary.Any<T1, T2> procedure;
}