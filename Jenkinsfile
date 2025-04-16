pipeline {
    agent any 

    tools {
        jdk 'java'
    }

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
                    allure([
                    includeProperties: false,
                    jdk: '',
                    results: [[path: 'allure-results']]
                ])
                }
            }
        }
    }
     post {
        always {
            publishHTML([allowMissing: false, alwaysLinkToLastBuild: false, icon: '', keepAll: false, reportDir: 'allure-report', reportFiles: 'index.html', reportName: 'HTML Report', reportTitles: '', useWrapperFileDirectly: true])
        }
        failure {
            echo 'Build failed! Check logs and reports.'
        }
    }
}