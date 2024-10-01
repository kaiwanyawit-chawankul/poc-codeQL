import csharp

/**
 * This class calculates cyclomatic complexity for methods.
 */
class CyclomaticComplexity {
    /**
     * Computes the cyclomatic complexity of a given method.
     * Cyclomatic complexity = E - N + 2P (where E = edges, N = nodes, P = connected components)
     */
    int compute(Method m) {
        int complexity = 1; // Start with 1 for the method itself
        int decisionPoints = m.getNumberOfControlFlowStatements(); // Count decision points

        return complexity + decisionPoints; // Total complexity
    }

    // Implement the toString method
    string toString() {
        result = "CyclomaticComplexity";
        return result;
    }
}

// Query to find methods with high cyclomatic complexity
from Method m
where CyclomaticComplexity().compute(m) > 10  // Adjust the threshold as needed
select m, "This method has a cyclomatic complexity greater than 10."
