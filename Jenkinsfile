pipeline {
    agent any  // Используем доступный агент

    stages {
        stage('Test') {
            steps {
                script {
                    echo 'Running tests...'
                    bat 'dotnet test PreparingForQualificationProject.sln'
                }
            }
        }

        stage('Report') {
            steps {
                script {
                    echo 'Generating report...'
                    bat 'allure generate allure-results -o allure-report --clean'
                }
            }
        }
    }
}