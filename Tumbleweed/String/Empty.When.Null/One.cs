namespace Tumbleweed.String.Empty.When.Null;

public sealed class One : Envelope
{
	public One(System.String? nullable) : this
	(
		new Nullable.From.System.One<System.String>(nullable)
	)
	{
	}
	
	public One(Nullable.Any<System.String> nullable) : this
	(
		new From.System.Nullable.One(nullable)
	)
	{
	}
	
	public One(Nullable.Any<Any> nullable) : base
	(
		new Spare.When.Null.One(nullable, "")
	)
	{
	}
}