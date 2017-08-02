var self = this;

self.onmessage = function (doc) {
    
    var lines = doc.data.split('\r\n');

    for (var i = 1; i < lines.length; i++) {

        var line = lines[i].split(',');

        var member = {};

        member.member_no = line[0];
        member.lastname = line[1];
        member.firstname = line[2];
        member.middleinitial = line[3];
        member.street = line[4];
        member.city = line[5];
        member.state_prov = line[6];
        member.country = line[7];
        member.mail_code = line[8];
        member.phone_no = line[9];
        member.issue_dt = line[10];
        member.expr_dt = line[11];
        member.corp_no = line[12];
        member.prev_balance = line[13];
        member.curr_balance = line[14];
        member.member_code = line[15];

        self.postMessage(member);

    }   

}