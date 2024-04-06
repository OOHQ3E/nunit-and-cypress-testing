describe('template spec', () => {
    it('passes', () => {
        cy.visit('https://www.globalsqa.com/angularJs-protractor/BankingProject/#/login')
        cy.get(':nth-child(3) > .btn').click()
        cy.get('[ng-class="btnClass1"]').click()
        cy.wait(200)
        cy.get(':nth-child(1) > .form-control').type("Elek")
        cy.get(':nth-child(2) > .form-control').type("Teszt")
        cy.get(':nth-child(3) > .form-control').type('3300')
        cy.get('form.ng-dirty > .btn').click()

        cy.get('[ng-class="btnClass2"]').click()
        cy.get('#userSelect').select("Elek Teszt")
        cy.get('#currency').select("Dollar")
        cy.get('form.ng-dirty > button').click()

        cy.get('.home').click()
        cy.get('.borderM > :nth-child(1) > .btn').click()
        cy.get('#userSelect').select("Elek Teszt")
        cy.get('form.ng-valid > .btn').click()

        cy.get('.fontBig').contains("Elek Teszt")
        cy.get('.borderM > :nth-child(3) > :nth-child(1)').contains("1016")
        cy.get(':nth-child(3) > :nth-child(2)').contains("0")
        cy.get('[ng-class="btnClass2"]').click()
        cy.get('.form-control').type("50")
        cy.get('form.ng-dirty > .btn').click()
        cy.get('.error').contains("Deposit Successful")
        cy.wait(1000)
        cy.get('[ng-class="btnClass1"]').click()
        cy.get('#anchor0 > :nth-child(1)').contains("Apr 6, 2024")
        cy.get('#anchor0 > :nth-child(2)').contains("50")
        cy.get('#anchor0 > :nth-child(3)').contains("Credit")
        cy.get('.home').click()


    })
})