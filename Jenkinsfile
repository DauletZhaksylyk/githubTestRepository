pipeline {
    agent any  // Используем доступный агент

    stages {
        stage('Test') {
            steps {
                script {
                    echo 'Running tests...'
                    bat 'dotnet test PreparingForQualificationProject.sln'  // Запуск тестов для всего решения
                }
            }
        }
    }
}