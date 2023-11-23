namespace Tumbleweed.Subroutine.Procedure.Nullary;

public abstract class Envelope : Any
{
	protected Envelope(Any procedure) =>
		this.procedure = procedure;
	
	public void Invoke() =>
		procedure.Invoke();

	private readonly Any procedure;
}