import csharp

// Cyclomatic complexity calculation
class CyclomaticComplexity {
    // Function to compute complexity
    int compute(Method m) {
        int complexity = 1; // Start with 1 for the method itself

        // Count the number of decision points
        complexity += m.getNumberOfControlFlowStatements();

        return complexity;
    }
}

// Query to find methods with high cyclomatic complexity
from Method m
where CyclomaticComplexity().compute(m) > 10  // Adjust the threshold as needed
select m, "This method has a cyclomatic complexity greater than 10."
