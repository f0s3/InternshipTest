namespace InternshipTest.Person {
    public class Student {
        string name;
        Knowledge knowledge;
        public Student(string name) {
            this.name = name;
            this.knowledge = new Knowledge(0);
        }

        public Student(string name, Knowledge knowledge) {
            this.name = name;
            SetKnowledge(knowledge);
        }

        public string GetName() {
            return this.name;
        }

        public void SetKnowledge(Knowledge knowledge) {
            this.knowledge = knowledge;
        }

        public Knowledge GetKnowledge() {
            return this.knowledge;
        }

        public int GetLevelOfKnowledge() {
            return this.knowledge.GetKnowledgeLevel();
        }
    }
}