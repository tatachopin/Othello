using System.Collections.Generic;

namespace Reversi.Model.Evaluation
{
	public interface INode
	{
	    float Value { get; }
        bool IsGameOver { get; }
	    void NextTurn();
        //IEnumerable<INode> Children { get; }
        List<GameStateNodeReference> ChildNodeReferences { get; }
        short PlayIndex { get; }
    }
}
