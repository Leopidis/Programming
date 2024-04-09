class DeterministicStackAutomaton:
    def __init__(self):
        self.stack = []

    def process_expression(self, expression):
        steps = []
        for char in expression:
            if char == 'x':
                self.stack.append('x')
            elif char == 'y' and self.stack:
                self.stack.pop()
            else:
                steps.append(f"Απόρριψη: Χαρακτήρας '{char}' δεν αναμένεται.")
                break
            steps.append(f"Βήμα: Χαρακτήρας '{char}' επεξεργάστηκε, Πίνακας: {self.stack}")
        
        if not self.stack:
            steps.append("Αποδοχή: Η έκφραση αναγνωρίστηκε επιτυχώς.")
        else:
            steps.append("Απόρριψη: Υπολειπόμενοι χαρακτήρες 'x' χωρίς αντίστοιχους 'y'.")
        
        return steps

# Παράδειγμα χρήσης
expression = "xxxyyx"
automaton = DeterministicStackAutomaton()
steps = automaton.process_expression(expression)

for step in steps:
    print(step)
