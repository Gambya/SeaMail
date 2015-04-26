# SeaMail
Biblioteca para envio de email, foi desenvolvida para agilizar o envio de email na hora do desenvolvimento de
uma aplicação que necessite desta funcionalidade.

Modo de uso

- Enviando email para apenas um destino:
SeaMail.Send(String host, String user, String password, String from, String to, String subject, String message);

Onde:
host - É o servidor SMTP utilizado para envio de email.(Exenplo: smtp.gmail.com);
user - É o usuário da conta que está enviando o email;
password - É a senha da conta que está enviando o email;
from - É o email da conta que está enviando o email;
to - É o email da conta que irá receber o email;
subject - É o assunto do email que está sendo enviado;
message - É o corpo do email, o texto a ser enviado;

- Enviando email para várias destinos:
SeaMail.Send(String host, String user, String password, String from, String[] to, String subject, String message);

Onde:
host - É o servidor SMTP utilizado para envio de email.(Exenplo: smtp.gmail.com);
user - É o usuário da conta que está enviando o email;
password - É a senha da conta que está enviando o email;
from - É o email da conta que está enviando o email;
to - É um array(vetor se preferir) contendo a lista de email's de contas que irão receber o email;
subject - É o assunto do email que está sendo enviado;
message - É o corpo do email, o texto a ser enviado;
