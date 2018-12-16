module Email

    type EmailModel (fromEmail: string, toEmail: string, password: string) =
        member x.fromEmail = fromEmail
        member x.toEmail = toEmail
        member x.password = "password"