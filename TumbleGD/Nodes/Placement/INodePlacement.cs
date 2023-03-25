using Godot;
using Tumbleweed.Scalars;

namespace TumbleGD.Nodes.Placement;

public interface INodePlacement
{
	void Place(IScalar<Node> parent);

	void Remove();
}