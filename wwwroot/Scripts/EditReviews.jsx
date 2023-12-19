class EditReviews extends React.Component {
    constructor(props) {
        super(props);
        this.state = {
            data: []
        };
    }
    componentDidMount() {
        // URLからIDを取得
        const urlParts = window.location.pathname.split('/');
        const id = urlParts[urlParts.length - 1];
        console.log("hello");


        $.ajax({
            url: ShipReviewsURL+"/" + id,
            type: "GET",
            dataType: "json",
            success: function (returnData) {
                if (returnData != null) {
                    this.setState({ data: [returnData] });
                    console.log(returnData);
                }
            }.bind(this),
            error: function (jqRequest, status, error) {
                console.log(status);
                console.log(jqRequest);
                console.log(error);
            }
        });
    }
    render() {
        function makeShipReviewList(x, index) {
            //console.log(this.state.data);
            return <EditShipReview key={index} data={x} />
        }
        return (
            <div >

                {this.state.data.map(makeShipReviewList)}
            </div>
        );
    }
}