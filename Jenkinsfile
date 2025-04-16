pipeline {
    agent any 

    environment {
        ALLURE_RESULTS_DIR = 'C:/Users/d.zhaksylyk/source/repos/githubTestRepository/PreparingForQualificationProject/bin/Debug/net8.0'
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
                    echo 'Generating report...'
                    bat 'allure generate --clean'
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