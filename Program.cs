using System;

namespace Operations_Decisions_Loops
{
    class Program
    {
        //Evaluaciones parciales
        //Trabajo en clase: 25
        //Practicas: 25
        //Participacion/Esfuerzo: 10
        //Proyecto: 40
        static float partialEvaluationWorkInClass = 0.25f;
        static float partialEvaluationPractice = 0.25f;
        static float partialEvaluationParticipation = 0.10f;
        static float partialEvaluationProject = 0.40f;

        //Evaluación semestral
        //Trabajo en clase: 15
        //Practicas: 20
        //Participacion/Esfuerzo: 5
        //Proyecto: 60
        static float semesterEvaluationWorkInClass = 0.15f;
        static float semesterEvaluationPractice = 0.20f;
        static float semesterEvaluationParticipation = 0.05f;
        static float semesterEvaluationProject = 0.60f;

        //limite inferior (mínimo) de puntos necesarios para poder tener calificacion semestral
        static float semesterResultAvailableThreshold = 12f;

        static float semesterResultPassThreshold = 6f;

        static float PartialEvaluation(float workInClass, float practice, float participation, 
        float project) {
            float partialResult = workInClass * partialEvaluationWorkInClass
                + practice * partialEvaluationPractice
                + participation * partialEvaluationParticipation
                + project * partialEvaluationProject;

            // Console.WriteLine("partial1Result = " + partial1Result);

            return partialResult;
        }

        static float SemesterEvaluation(float workInClass, float practice, float participation, float project) {
            float semesterResult = workInClass * semesterEvaluationWorkInClass
                + practice * semesterEvaluationPractice
                + participation * semesterEvaluationParticipation
                + project * semesterEvaluationProject;

            return semesterResult;
        }

        static void Main(string[] args)
        {
            

            float partial1Result;
            float partial2Result;
            float semesterResult;

            // partial1Result = 10 * partialEvaluationWorkInClass
            //     + 10 * partialEvaluationPractice
            //     + 10 * partialEvaluationParticipation
            //     + 10 * partialEvaluationProject;

            partial1Result = PartialEvaluation(3f, 1f, 2f, 6f);

            Console.WriteLine("partial1Result = " + partial1Result);
            
            // partial2Result = 10 * partialEvaluationWorkInClass
            //     + 10 * partialEvaluationPractice
            //     + 10 * partialEvaluationParticipation
            //     + 10 * partialEvaluationProject;
            partial2Result = PartialEvaluation(10f, 10f, 10f, 3f);

            Console.WriteLine("partial2Result = " + partial2Result);
            
            // semesterResult = 10 * semesterEvaluationWorkInClass
            //     + 10 * semesterEvaluationPractice
            //     + 10 * semesterEvaluationParticipation
            //     + 10 * semesterEvaluationProject;


            //Si juntamos 12 puntos en los primeros 2 parciales, se tiene derecho a calificación
            if (partial1Result + partial2Result >= semesterResultAvailableThreshold) {
                semesterResult = SemesterEvaluation(10f, 10f, 10f, 6f);
            //Si no se juntan los 12 puntos, el alumno no tiene derecho a calificación (0)
            } else {
                semesterResult = 0f;
            }


            Console.WriteLine("semesterResult = " + semesterResult);
            if (semesterResult >= semesterResultPassThreshold) { 
                Console.WriteLine("APROBADO");
            } else {
                Console.WriteLine("REPORBADO");
            }
        }
    }
}
